using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for redirect-based verification.
    /// </summary>
    /// <remarks>
    /// Implementations generate a redirect URL (deep link, OAuth URL, etc.) that the user visits
    /// to complete a verification flow. When the user completes the flow, the provider notifies
    /// the server via <see cref="IVerificationCallback"/>.
    /// <para>
    /// The provider does not need to know the purpose of the verification (registration,
    /// phone verification, password recovery). It generates a URL, collects identity information,
    /// and calls back. The server determines the outcome based on the session/token type.
    /// </para>
    /// </remarks>
    [IntegrationCapability("35D7F06E-2839-4F9F-8691-B67A9A916863")]
    public interface IVerificationRedirectHandler
    {
        /// <summary>
        /// Generates a redirect URL for the verification flow.
        /// </summary>
        /// <param name="context">The context containing the token value to embed as a nonce.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A result containing the redirect URL and its expiration.</returns>
        Task<VerificationRedirectResult> CreateRedirectUrlAsync(
            CreateRedirectUrlContext context,
            CancellationToken cancellationToken = default);
    }
}
