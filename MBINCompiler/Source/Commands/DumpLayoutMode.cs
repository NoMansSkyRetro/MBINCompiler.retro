using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    /// <summary>
    /// Dump every NMSTemplate struct's authoritative memory layout (field name, type, byte
    /// offset, size) as JSON to stdout, using libMBIN's own OffsetOf/SizeOf so the alignment
    /// logic is never reimplemented.
    ///
    /// This is the retro pipeline's first-class output: per-build struct layouts for tools
    /// that read the game's structs from memory (see the RetroMBINCompiler notes in the
    /// README). The compiled-in definitions are the rc1 / launch layout; --nms-version only
    /// labels the dump, since a single binary carries one definition set.
    ///
    /// stdout is a flat { "StructName": { guid, size, fields:[{name,type,offset,size}] } }
    /// map (a drop-in for NMS.retro.py's gen_structs.py); the build id + template count go to
    /// stderr, mirroring the standalone structdump tool.
    /// </summary>
    internal class DumpLayoutCommand : Command<DumpLayoutCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            // Only the compiled-in (rc1) definitions exist in this binary; warn if a different
            // build was requested so the dump is not mistaken for that build's own layout.
            string requested = RetroVersion.Selected?.Id;
            if ( requested != null && requested != RetroVersion.CompiledInId ) {
                CommandLine.ShowWarning(
                    $"--nms-version {requested}: this binary carries the {RetroVersion.CompiledInId} " +
                    "definitions; dumping those. Per-build definition sets are the RE frontier." );
            }
            string build = RetroVersion.CompiledInId;

            var baseType = typeof( NMSTemplate );
            var structs = baseType.Assembly.GetTypes()
                .Where( t => t.IsSubclassOf( baseType ) && !t.IsAbstract )
                .OrderBy( t => t.Name, StringComparer.Ordinal );

            var sb = new StringBuilder();
            sb.Append( '{' );
            bool firstStruct = true;
            int count = 0;
            foreach ( var t in structs ) {
                ulong guid = t.GetCustomAttribute<NMSAttribute>()?.GUID ?? 0;

                var fields = new List<(string name, string type, int off, int size)>();
                foreach ( var f in t.GetFields( BindingFlags.Public | BindingFlags.Instance ) ) {
                    int off; int sz;
                    try { off = NMSTemplate.OffsetOf( t, f.Name ); } catch { off = -1; }
                    try { sz  = NMSTemplate.SizeOf( f ); }          catch { sz  = -1; }
                    fields.Add( (f.Name, f.FieldType.Name, off, sz) );
                }
                int total;
                try { total = NMSTemplate.SizeOf( t ); } catch { total = -1; }

                if ( !firstStruct ) sb.Append( ',' );
                firstStruct = false;
                sb.Append( JsonStr( t.Name ) ).Append( ":{" );
                sb.Append( "\"guid\":\"" ).Append( guid.ToString( "X16" ) ).Append( "\"," );
                sb.Append( "\"size\":" ).Append( total ).Append( ',' );
                sb.Append( "\"fields\":[" );
                bool firstField = true;
                foreach ( var f in fields.OrderBy( x => x.off ) ) {
                    if ( !firstField ) sb.Append( ',' );
                    firstField = false;
                    sb.Append( "{\"name\":" ).Append( JsonStr( f.name ) )
                      .Append( ",\"type\":" ).Append( JsonStr( f.type ) )
                      .Append( ",\"offset\":" ).Append( f.off )
                      .Append( ",\"size\":" ).Append( f.size ).Append( '}' );
                }
                sb.Append( "]}" );
                count++;
            }
            sb.Append( '}' );

            Console.Out.Write( sb.ToString() );
            Console.Out.Flush();
            Console.Error.WriteLine( $"[dumplayout] build={build} container={MBINHeader.MBIN_VERSION} {count} templates" );
            return (int) ErrorCode.Success;
        }

        private static string JsonStr( string s ) {
            var sb = new StringBuilder( s.Length + 2 );
            sb.Append( '"' );
            foreach ( var c in s ) {
                switch ( c ) {
                    case '"':  sb.Append( "\\\"" ); break;
                    case '\\': sb.Append( "\\\\" ); break;
                    default:   sb.Append( c ); break;
                }
            }
            sb.Append( '"' );
            return sb.ToString();
        }
    }
}
