namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Asset error code.
    /// </summary>
    public enum AssetExceptionErrorCode
    {
        /// <summary>
        /// Not checked in.
        /// </summary>
        [Localized("ASSET_ERROR_NOT_CHECKED_IN")]
        NotCheckedIn = 0,
        /// <summary>
        /// Already checked in.
        /// </summary>
        [Localized("ASSET_ERROR_ALREADY_CHECKED_IN")]
        AlreadyCheckedIn = 1,
        /// <summary>
        /// Asset disabled.
        /// </summary>
        [Localized("ASSET_ERROR_DISABLED")]
        AssetDisabled = 2,
    }
}
