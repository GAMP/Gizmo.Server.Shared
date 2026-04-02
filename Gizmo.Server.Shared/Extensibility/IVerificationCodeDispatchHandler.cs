using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for dispatching confirmation codes to known recipients.
    /// </summary>
    /// <remarks>
    /// Implementations deliver a confirmation code to a recipient identified by their
    /// channel-specific value (e.g. Telegram chat ID, phone number for SMS).
    /// </remarks>
    [IntegrationCapability("B179770C-1CC7-4129-B5A4-6A5DB5C52453")]
    public interface IVerificationCodeDispatchHandler
    {
        /// <summary>
        /// Sends a confirmation code to a known recipient.
        /// </summary>
        /// <param name="context">The context containing recipient, code, and token information.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The result of the dispatch operation.</returns>
        Task<SendCodeResult> SendCodeAsync(
            SendCodeContext context,
            CancellationToken cancellationToken = default);
    }
}
