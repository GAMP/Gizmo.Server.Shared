namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for creating a messenger registration link.
    /// </summary>
    public sealed class CreateRegistrationLinkContext
    {
        /// <summary>
        /// Gets the token value identifying this registration operation.
        /// </summary>
        public required string TokenValue { get; init; }

        /// <summary>
        /// Gets the confirmation code to send to the user when the link is claimed.
        /// </summary>
        public required string ConfirmationCode { get; init; }
    }
}
