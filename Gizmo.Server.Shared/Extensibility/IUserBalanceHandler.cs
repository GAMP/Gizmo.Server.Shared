using Gizmo.Extensibility;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for handling user balance calculations.
    /// </summary>
    /// <remarks>
    /// Implementations can intercept the balance calculation pipeline at two stages:
    /// <list type="number">
    /// <item>
    ///   <description>
    ///   <see cref="HandlePreBalanceAsync"/> — called before the default balance calculation.
    ///   Return a non-null dictionary to replace the default calculation entirely.
    ///   Return <see langword="null"/> to let the default calculation proceed.
    ///   </description>
    /// </item>
    /// <item>
    ///   <description>
    ///   <see cref="HandlePostBalanceAsync"/> — called after the default balance calculation
    ///   completes. Allows modification of the calculated <see cref="UserBalanceData"/> values
    ///   before they are cached.
    ///   </description>
    /// </item>
    /// </list>
    /// <para>
    /// <b>Pipeline flow:</b> If <see cref="HandlePreBalanceAsync"/> returns a non-null result,
    /// the default calculation and <see cref="HandlePostBalanceAsync"/> are both skipped.
    /// If it returns <see langword="null"/>, the default calculation runs followed by
    /// <see cref="HandlePostBalanceAsync"/>.
    /// </para>
    /// <para>
    /// A plugin typically implements one stage — <see cref="HandlePreBalanceAsync"/> to fully
    /// replace balance sourcing (e.g. external billing system), or
    /// <see cref="HandlePostBalanceAsync"/> to adjust host-calculated balances.
    /// Default interface methods are provided so only the relevant stage needs to be overridden.
    /// </para>
    /// <para>
    /// When <see cref="UserBalanceContext.UserId"/> is specified, the returned dictionary
    /// must contain an entry keyed by that user ID. When <see langword="null"/>, the handler
    /// is responsible for returning balances for all applicable users.
    /// </para>
    /// </remarks>
    [IntegrationCapability("11DB6DAE-D6FD-42A9-90D6-2C046E4B3AB5")]
    public interface IUserBalanceHandler
    {
        /// <summary>
        /// Handles pre-balance calculation, optionally replacing the default calculation.
        /// </summary>
        /// <param name="context">The balance calculation context.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// A dictionary of user balances keyed by user ID to replace the default calculation,
        /// or <see langword="null"/> to let the default calculation proceed.
        /// </returns>
        ValueTask<IReadOnlyDictionary<int, UserBalanceData>?> HandlePreBalanceAsync(
            UserBalanceContext context,
            CancellationToken cancellationToken = default)
        {
            return new(default(IReadOnlyDictionary<int, UserBalanceData>?));
        }

        /// <summary>
        /// Handles post-balance calculation, allowing modification of calculated balances.
        /// </summary>
        /// <param name="context">The balance calculation context.</param>
        /// <param name="balances">
        /// The calculated balances from the default calculation. Implementations may modify
        /// <see cref="UserBalanceData"/> property values directly.
        /// </param>
        /// <param name="cancellationToken">Cancellation token.</param>
        ValueTask HandlePostBalanceAsync(
            UserBalanceContext context,
            IReadOnlyDictionary<int, UserBalanceData> balances,
            CancellationToken cancellationToken = default)
        {
            return ValueTask.CompletedTask;
        }
    }
}
