namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Server-side callback for verification events.
    /// </summary>
    /// <remarks>
    /// Implementations are provided by the server and injected into verification providers via DI.
    /// Providers call <see cref="OnCallbackAsync"/> when a redirect flow completes (e.g. user
    /// scans a QR code, completes an OAuth flow) or when a deferred code dispatch resolves.
    /// </remarks>
    public interface IVerificationCallback
    {
        /// <summary>
        /// Called by the verification provider when an operation completes.
        /// </summary>
        /// <param name="result">The callback result containing the token value and collected metadata.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        Task OnCallbackAsync(
            VerificationCallbackResult result,
            CancellationToken cancellationToken = default);
    }
}
