namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Keys for metadata provided by verification providers in callback results.
    /// </summary>
    public enum VerificationCallbackMetadataKey
    {
        /// <summary>
        /// User's phone number.
        /// </summary>
        PhoneNumber,

        /// <summary>
        /// User's first name.
        /// </summary>
        FirstName,

        /// <summary>
        /// User's last name.
        /// </summary>
        LastName,

        /// <summary>
        /// Communication channel type GUID.
        /// </summary>
        ChannelType,

        /// <summary>
        /// User's email address.
        /// </summary>
        Email,
    }
}
