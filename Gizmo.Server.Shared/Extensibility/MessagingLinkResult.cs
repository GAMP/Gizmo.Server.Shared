namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of creating a messenger deep-link.
    /// </summary>
    public sealed class MessagingLinkResult
    {
        /// <summary>
        /// Gets the deep-link URL for the user to open (displayed as a QR code).
        /// </summary>
        public required string LinkUrl { get; init; }

        /// <summary>
        /// Gets the nonce embedded in the link, used to track the claim.
        /// </summary>
        public required string Nonce { get; init; }

        /// <summary>
        /// Gets the number of seconds before this link expires.
        /// </summary>
        public required int ExpiresInSeconds { get; init; }
    }
}
