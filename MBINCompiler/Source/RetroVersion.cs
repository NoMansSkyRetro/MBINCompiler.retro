using System;
using libMBIN;

namespace MBINCompiler {

    /// <summary>
    /// Retro build identity for the legacy No Man's Sky versions this fork targets.
    ///
    /// The compiled-in struct definitions are the RC1 / launch layout carried by the rc1
    /// branch. Each build below is fingerprinted by the decimal timestamp stamp
    /// (YYYYMMDDHHMM) and the root-globals GUID that its vanilla (format V0) MBINs carry, so
    /// a stamped MBIN can be identified automatically. MBINs that carry no stamp (most files
    /// other than the *.GLOBAL templates) fall back to the --nms-version flag.
    ///
    /// Fingerprints come from the NMS.retro.py probe over each legacy install's PAKs
    /// (tools/mbin/probe_versions.py).
    /// </summary>
    internal static class RetroVersion {

        public struct Build {
            public string Id;          // --nms-version value, e.g. "1.24"
            public string Name;        // update name, e.g. "Path Finder"
            public ulong  Stamp;       // GCENVIRONMENTGLOBALS.GLOBAL stamp, 0 when unknown
            public ulong  GlobalsGUID; // its template GUID, 0 when unknown
        }

        public static readonly Build[] Builds = new [] {
            new Build { Id = "rc1",    Name = "Release Candidate", Stamp = 0UL,          GlobalsGUID = 0UL },
            new Build { Id = "1.09.1", Name = "Release",           Stamp = 201609151009, GlobalsGUID = 0x7874BDDACA5369F2 },
            new Build { Id = "1.13",   Name = "Foundation",        Stamp = 201610210932, GlobalsGUID = 0x921F6EE7A2F8E1F4 },
            new Build { Id = "1.24",   Name = "Path Finder",       Stamp = 201703231221, GlobalsGUID = 0xD3678373BD2A38F3 },
            new Build { Id = "1.38",   Name = "Atlas Rises",       Stamp = 201709282000, GlobalsGUID = 0x7DB5F3DF6DFEC088 },
        };

        /// <summary>The build whose struct definitions are compiled into this binary (rc1 branch).</summary>
        public const string CompiledInId = "rc1";

        /// <summary>The build chosen with --nms-version, or null if the flag was not given.</summary>
        public static Build? Selected { get; private set; }

        public static bool TryParse( string id, out Build build ) {
            build = default;
            if ( string.IsNullOrWhiteSpace( id ) ) return false;
            id = id.Trim();
            foreach ( var b in Builds ) {
                if ( string.Equals( b.Id, id, StringComparison.OrdinalIgnoreCase ) ) { build = b; return true; }
            }
            return false;
        }

        /// <summary>Set the active build from the --nms-version flag. Returns false for an unknown id.</summary>
        public static bool Select( string id ) {
            if ( !TryParse( id, out var b ) ) return false;
            Selected = b;
            return true;
        }

        /// <summary>Identify the build a vanilla MBIN came from, by its stamp then globals GUID. Null if undetermined.</summary>
        public static Build? Detect( MBINHeader header ) {
            if ( header == null || !header.IsFormatV0 ) return null; // stamp/GUID fields only mean this in V0
            foreach ( var b in Builds ) {
                if ( b.Stamp != 0UL && header.Timestamp == b.Stamp ) return b;
            }
            foreach ( var b in Builds ) {
                if ( b.GlobalsGUID != 0UL && header.TemplateGUID == b.GlobalsGUID ) return b;
            }
            return null;
        }

        /// <summary>Build to use for an MBIN: explicit --nms-version wins, else autodetect, else null.</summary>
        public static Build? Resolve( MBINHeader header ) => Selected ?? Detect( header );

        public static string IdList() => string.Join( "|", Array.ConvertAll( Builds, b => b.Id ) );
    }
}
