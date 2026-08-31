using System;

namespace libMBIN {

    /// <summary>
    /// Retro multi-version support. This fork carries a complete struct definition set per
    /// targeted NMS build, each in its own namespace folder, all compiled into one libMBIN:
    ///
    ///   rc1                   the base set        libMBIN.NMS.*      (the rc1 branch defs)
    ///   1.09.1 (Release)      libMBIN.V1_09_1.*   (derived per struct, falls back to base)
    ///   1.13 (Foundation)     libMBIN.V1_13.*     (imported 1a6c980e, falls back to base)
    ///   1.24 (Path Finder)    libMBIN.V1_24.*     (imported 1.24.4 tag)
    ///   1.38 (Atlas Rises)    libMBIN.V1_38.*     (imported 1.38.0.2 tag)
    ///
    /// The active build selects which folder resolves a template (see
    /// NMSTemplate.GetTemplateType); there are no per-field version deltas. MBINCompiler's
    /// RetroVersion sets the active build from --nms-version / autodetection.
    /// </summary>
    public static class NMSVersion {

        // Oldest -> newest. Rank is the array index.
        public static readonly string[] Order = { "rc1", "1.09.1", "1.13", "1.24", "1.38" };

        public static int Rank( string id ) => id == null ? -1 : Array.IndexOf( Order, id );

        /// <summary>Active build id, or null for the base (rc1) set.</summary>
        public static string ActiveId = null;

        public static int ActiveRank => Rank( ActiveId );

        public static void SetActive( string id ) => ActiveId = id;
        public static void Clear() => ActiveId = null;

        /// <summary>
        /// Namespace prefix of the active build's own struct folder, e.g. "1.24" -> libMBIN.V1_24.
        /// Builds with no dedicated folder (rc1) map to a prefix that matches nothing, so they
        /// fall back to the base set; partial folders fall back per template.
        /// </summary>
        public static string FolderPrefix => "libMBIN.V" + (ActiveId ?? "").Replace( ".", "_" );

        /// <summary>True if a type belongs to some version's dedicated folder (not the base set).</summary>
        public static bool IsVersionedNamespace( string ns ) => ns != null && ns.StartsWith( "libMBIN.V1_" );
    }
}
