namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for sending a confirmation code to a known recipient.
    /// </summary>
    public sealed class SendConfirmationCodeContext
    {
        /// <summary>
        /// Gets the recipient address (e.g. messenger chat ID).
        /// </summary>
        public required string RecipientAddress { get; init; }

        /// <summary>
        /// Gets the confirmation code to deliver.
        /// </summary>
        public required string ConfirmationCode { get; init; }
    }
}
