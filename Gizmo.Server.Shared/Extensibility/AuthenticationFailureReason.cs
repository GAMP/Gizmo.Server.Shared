namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Specifies the reason an authentication attempt failed.
    /// </summary>
    /// <remarks>
    /// These values represent authentication-phase failures only (credential validation).
    /// Session/login-phase failures (e.g. insufficient balance, slot in use) are outside
    /// the scope of authentication and are handled separately.
    /// </remarks>
    public enum AuthenticationFailureReason
    {
        /// <summary>
        /// No failure.
        /// </summary>
        None = 0,

        /// <summary>
        /// The specified user name does not exist.
        /// </summary>
        InvalidUserName = 1,

        /// <summary>
        /// The provided password is incorrect.
        /// </summary>
        InvalidPassword = 2,

        /// <summary>
        /// The user account is disabled.
        /// </summary>
        AccountDisabled = 3,

        /// <summary>
        /// Authentication was denied for an unspecified reason.
        /// </summary>
        Denied = 4,
    }
}
