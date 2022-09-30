namespace Gizmo.Server.Services
{
    /// <summary>
    /// Title templates.
    /// </summary>
    /// <remarks>
    /// Currently only email messages will have an title.<br/>
    /// SMS messages will provide context inside of the message itself.
    /// </remarks>
    public enum TitleTemplate
    {
        /// <summary>
        /// Password recovery title.
        /// </summary>
        PasswordRecovery = 0,
        /// <summary>
        /// Registration title.
        /// </summary>
        Registration = 1,
        /// <summary>
        /// Verify email title.
        /// </summary>
        VerifyEmail = 2,
        /// <summary>
        /// Business name title.
        /// </summary>
        BusinessName = 3,
    }
}
