using System;
using System.Reflection;

namespace libMBIN {

    /// <summary>
    /// Retro multi-version support. Struct fields that differ across the targeted legacy NMS
    /// builds carry <see cref="NMSVersionAttribute"/>; the (de)serialise field walk includes
    /// only the fields valid for the active build. Untagged fields belong to every build.
    ///
    /// With no active build set (<see cref="ActiveRank"/> &lt; 0) nothing is filtered, so the
    /// behaviour is identical to single-version libMBIN. MBINCompiler's RetroVersion sets the
    /// active build from --nms-version / autodetection.
    /// </summary>
    public static class NMSVersion {

        // Oldest -> newest. Rank is the array index.
        public static readonly string[] Order = { "rc1", "1.09.1", "1.13", "1.24", "1.38" };

        public static int Rank( string id ) => id == null ? -1 : Array.IndexOf( Order, id );

        /// <summary>Active build rank, or -1 for "no filtering" (single-version behaviour).</summary>
        public static int ActiveRank = -1;

        public static void SetActive( string id ) => ActiveRank = Rank( id );
        public static void Clear() => ActiveRank = -1;

        /// <summary>Is this field present in the active build? Untagged = yes; no active build = yes.</summary>
        public static bool IsActive( FieldInfo field ) {
            if ( ActiveRank < 0 ) return true;
            var v = field.GetCustomAttribute<NMSVersionAttribute>();
            if ( v == null ) return true;
            if ( v.FirstRank >= 0 && ActiveRank < v.FirstRank ) return false;
            if ( v.LastRank  >= 0 && ActiveRank > v.LastRank )  return false;
            return true;
        }
    }

    /// <summary>Marks a struct field as present only for a range of NMS builds (see <see cref="NMSVersion.Order"/>).</summary>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public class NMSVersionAttribute : Attribute {
        /// <summary>First build id the field appears in (inclusive). Null = from the earliest build.</summary>
        public string First { get; set; }
        /// <summary>Last build id the field appears in (inclusive). Null = through the latest build.</summary>
        public string Last  { get; set; }

        public int FirstRank => NMSVersion.Rank( First );
        public int LastRank  => NMSVersion.Rank( Last );
    }
}
