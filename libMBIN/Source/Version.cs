namespace libMBIN {

    /// <summary>Version Utilities</summary>
    public static class Version {

        // THIS IS THE MASTER VERSION STRING. MAKE VERSION CHANGES HERE.
        // Used by libMBIN.AssemblyInfo, MBINCompiler.AssemblyInfo
        // and (this) libMBIN.Version
        //
        // The format is "Major.Minor.Patch.Prerelease".
        //
        // MBINCompiler.retro versions itself independently (it targets many NMS builds at
        // once), so it follows plain semver: Major.Minor.Patch, starting at 1.0.0. The 4th
        // number is an optional prerelease counter - if it is non-zero the build displays a
        // "-pre{N}" suffix; a zero 4th number is a normal release.
        internal const string VERSION_STRING = "1.0.0.0";

        /// <summary>Shorthand for AssemblyVersion.Major</summary>
        public static int Major      => AssemblyVersion.Major;
        /// <summary>Shorthand for AssemblyVersion.Minor</summary>
        public static int Minor      => AssemblyVersion.Minor;
        /// <summary>Shorthand for AssemblyVersion.Build</summary>
        public static int Release    => AssemblyVersion.Build;
        /// <summary>Shorthand for AssemblyVersion.Revision</summary>
        public static int Prerelease => AssemblyVersion.Revision;

        /// <summary>The libMBIN assembly version.</summary>
        public static System.Version AssemblyVersion => new System.Version( VERSION_STRING );

        /// <summary>
        ///     The NMS version that is supported by this assembly.
        ///     (The <see cref="Major"/>, <see cref="Minor"/> and <see cref="Release"/> components of <see cref="AssemblyVersion"/>)
        /// </summary>
        public static System.Version NMSVersion => new System.Version( Major, Minor, Release, 0 );

        /// <summary>
        ///     Returns a human-readable suffix indicating the <see cref="Prerelease"/> version.
        /// </summary>
        /// <returns>
        ///     If the current assembly version is a prerelease (<see cref="Release"/> is 0 or <see cref="Prerelease"/> is not 0) then "-pre{Prerelease}" is returned.
        ///     Otherwise returns an emptry string.
        /// </returns>
        public static string GetSuffix() => (Prerelease != 0) ? $"-pre{Prerelease}" : "";

        /// <summary>
        ///     Returns the assembly version in a human-readable string format.
        ///     Eg. "1.1.0" (Release) or "1.1.0-pre1" (Pre-Release)
        /// </summary>
        /// <returns>"{<see cref="Major"/>}.{<see cref="Minor"/>}.{<see cref="Release"/>}{<see cref="GetSuffix">Suffix</see>}"</returns>
        public static string GetString() {
            return $"{AssemblyVersion.Major}.{AssemblyVersion.Minor}.{AssemblyVersion.Build}"  + GetSuffix();
        }
    }
}
