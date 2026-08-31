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
    /// that read the game's structs from memory (see the MBINCompiler.retro notes in the
    /// README). --nms-version selects the build; the dump is that build's effective set
    /// (its own folder overlaid on the shared base), exactly as the runtime resolves types.
    ///
    /// stdout is a flat { "StructName": { guid, size, fields:[{name,type,offset,size}] } }
    /// map (a drop-in for NMS.retro.py's gen_structs.py); the build id + template count go to
    /// stderr, mirroring the standalone structdump tool.
    /// </summary>
    internal class DumpLayoutCommand : Command<DumpLayoutCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            // Dump the active build's *effective* struct set, exactly as the runtime resolves it
            // (NMSTemplate.GetTemplateType): the build's own folder wins per template name, and
            // every name it does not override falls back to the shared base set. So 1.24/1.38
            // (near-complete folders) and 1.09.1/1.13 (small delta folders over the base) all
            // emit the full layout their build actually uses, not just the folder's overrides.
            string build = RetroVersion.Selected?.Id ?? RetroVersion.CompiledInId;
            string folder = NMSVersion.FolderPrefix;

            var baseType = typeof( NMSTemplate );
            // Match the resolver's universe (NMSTemplate.BaseTemplateMap / VersionTemplateMaps):
            // direct NMSTemplate subclasses, split into the active folder vs the base set.
            var all = baseType.Assembly.GetTypes()
                .Where( t => t.BaseType == baseType && !t.IsAbstract );
            var folderMap = all.Where( t => t.Namespace?.StartsWith( folder ) ?? false )
                .GroupBy( t => t.Name ).ToDictionary( g => g.Key, g => g.First() );
            var baseMap = all.Where( t => !NMSVersion.IsVersionedNamespace( t.Namespace ) )
                .GroupBy( t => t.Name ).ToDictionary( g => g.Key, g => g.First() );

            bool dumpAll = Environment.GetEnvironmentVariable( "MBIN_DUMPLAYOUT_ALL" ) == "1";
            IEnumerable<Type> structs;
            if ( dumpAll ) {
                structs = all.OrderBy( t => t.FullName, StringComparer.Ordinal );
            } else {
                var names = new SortedSet<string>( StringComparer.Ordinal );
                names.UnionWith( baseMap.Keys );
                names.UnionWith( folderMap.Keys );
                structs = names.Select( n => folderMap.TryGetValue( n, out var tv ) ? tv : baseMap[n] );
            }

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
                sb.Append( JsonStr( dumpAll ? t.FullName : t.Name ) ).Append( ":{" );
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
