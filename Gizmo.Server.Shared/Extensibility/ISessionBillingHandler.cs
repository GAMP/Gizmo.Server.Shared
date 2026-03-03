namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for handling user session billing.
    /// </summary>
    /// <remarks>
    /// Implementations can replace the default session billing logic that runs on each
    /// billing cycle tick. The server periodically bills active user sessions by deducting
    /// time or money based on billing profiles and rate configurations.
    /// <para>
    /// <see cref="HandleBillSessionAsync"/> is called for each active session during the
    /// billing cycle. Return a non-null <see cref="SessionBillingResult"/> to indicate
    /// the billing was handled (the default billing logic is skipped). Return
    /// <see langword="null"/> to let the default billing logic proceed.
    /// </para>
    /// <para>
    /// The <see cref="SessionBillingResult.ShouldLogout"/> property controls whether the
    /// user session should be terminated after billing (e.g. when balance is exhausted).
    /// </para>
    /// </remarks>
    public interface ISessionBillingHandler
    {
        /// <summary>
        /// Handles billing for a user session.
        /// </summary>
        /// <param name="context">The billing context containing session and user information.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// A <see cref="SessionBillingResult"/> if the billing was handled,
        /// or <see langword="null"/> to let the default billing logic proceed.
        /// </returns>
        ValueTask<SessionBillingResult?> HandleBillSessionAsync(
            SessionBillingContext context,
            CancellationToken cancellationToken = default);
    }
}
