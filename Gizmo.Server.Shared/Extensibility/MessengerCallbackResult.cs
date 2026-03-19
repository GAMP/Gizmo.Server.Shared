namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Base class for messenger verification callback results.
    /// </summary>
    public abstract class MessengerCallbackResult
    {
        /// <summary>
        /// Gets the token value identifying the operation.
        /// </summary>
        public required string TokenValue { get; init; }
    }

    /// <summary>
    /// Callback result for phone verification via messenger.
    /// The link was claimed — the user scanned the QR and opened the bot.
    /// </summary>
    public sealed class MessengerVerificationCallbackResult : MessengerCallbackResult
    {
        /// <summary>
        /// Gets the recipient address (e.g. messenger chat ID) captured from the user.
        /// </summary>
        public required string RecipientAddress { get; init; }
    }

    /// <summary>
    /// Callback result for account registration via messenger.
    /// The link was claimed and the confirmation code was sent to the user.
    /// </summary>
    public sealed class MessengerRegistrationCallbackResult : MessengerCallbackResult
    {
        /// <summary>
        /// Gets the recipient address (e.g. messenger chat ID) captured from the user.
        /// </summary>
        public required string RecipientAddress { get; init; }
    }
}
