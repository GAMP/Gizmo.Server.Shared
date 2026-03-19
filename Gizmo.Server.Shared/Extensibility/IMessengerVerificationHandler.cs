using Gizmo.Extensibility;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for messenger-based user verification.
    /// </summary>
    /// <remarks>
    /// Implementations handle verification, registration, and confirmation code delivery
    /// through a messaging platform (e.g. Telegram, WhatsApp). The server does not know
    /// which platform is used — it interacts only through this interface.
    /// <para>
    /// <see cref="CreateVerificationLinkAsync"/> generates a deep-link URL for phone verification.
    /// When the user opens the link, the handler captures the recipient address and notifies
    /// the server via <see cref="IMessengerVerificationCallback"/>. No confirmation code is involved.
    /// </para>
    /// <para>
    /// <see cref="CreateRegistrationLinkAsync"/> generates a deep-link URL for new account registration.
    /// When the user opens the link, the handler sends the provided confirmation code to the user
    /// and notifies the server via <see cref="IMessengerVerificationCallback"/>.
    /// </para>
    /// <para>
    /// <see cref="SendConfirmationCodeAsync"/> delivers a confirmation code to a known recipient
    /// (e.g. for password recovery, re-verification, or 2FA) without requiring a deep-link flow.
    /// </para>
    /// </remarks>
    [IntegrationCapability("A1B2C3D4-1001-4000-8000-000000000004")]
    public interface IMessengerVerificationHandler
    {
        /// <summary>
        /// Generates a deep-link URL for phone verification. No confirmation code is sent.
        /// </summary>
        /// <param name="context">The verification link context.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A link result containing the URL and nonce for the client to display as a QR code.</returns>
        Task<MessagingLinkResult> CreateVerificationLinkAsync(
            CreateVerificationLinkContext context,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a deep-link URL for new account registration.
        /// When the user opens the link, the handler sends the confirmation code.
        /// </summary>
        /// <param name="context">The registration link context containing the confirmation code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A link result containing the URL and nonce for the client to display as a QR code.</returns>
        Task<MessagingLinkResult> CreateRegistrationLinkAsync(
            CreateRegistrationLinkContext context,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a confirmation code to a known recipient.
        /// </summary>
        /// <param name="context">The context containing recipient address and confirmation code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns><see langword="true"/> if the code was delivered successfully.</returns>
        Task<bool> SendConfirmationCodeAsync(
            SendConfirmationCodeContext context,
            CancellationToken cancellationToken = default);
    }
}
