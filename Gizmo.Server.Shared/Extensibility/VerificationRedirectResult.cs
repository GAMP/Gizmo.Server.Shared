namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of creating a verification redirect URL.
    /// </summary>
    public sealed class VerificationRedirectResult
    {
        /// <summary>
        /// Gets the redirect URL for the user to visit.
        /// </summary>
        public required string RedirectUrl { get; init; }

        /// <summary>
        /// Gets the number of seconds before this redirect URL expires.
        /// </summary>
        public required int ExpiresInSeconds { get; init; }
    }
}
