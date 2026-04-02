namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for sending a confirmation code to a known recipient.
    /// </summary>
    public sealed class SendCodeContext
    {
        /// <summary>
        /// Gets the token value identifying this verification operation.
        /// </summary>
        public required string TokenValue { get; init; }

        /// <summary>
        /// Gets the recipient's channel-specific identifier (e.g. chat ID, phone number).
        /// </summary>
        public required string ChannelValue { get; init; }

        /// <summary>
        /// Gets the confirmation code to deliver.
        /// </summary>
        public required string Code { get; init; }
    }
}
