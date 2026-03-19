namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Server-side callback for messenger verification events.
    /// </summary>
    /// <remarks>
    /// Implementations are provided by the server and injected into messenger handlers via DI.
    /// When a user claims a deep-link (e.g. by scanning a QR code and opening the bot),
    /// the handler calls <see cref="OnCallbackAsync"/> with the appropriate result type.
    /// The server dispatches based on the concrete result type.
    /// </remarks>
    public interface IMessengerVerificationCallback
    {
        /// <summary>
        /// Called by the messenger handler when a link is claimed or an operation completes.
        /// </summary>
        /// <param name="result">The callback result. The concrete type determines the server's behavior.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        Task OnCallbackAsync(
            MessengerCallbackResult result,
            CancellationToken cancellationToken = default);
    }
}
