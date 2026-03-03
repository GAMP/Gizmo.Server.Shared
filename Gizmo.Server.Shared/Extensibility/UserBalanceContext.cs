using Microsoft.EntityFrameworkCore;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for a user balance calculation request.
    /// </summary>
    public sealed class UserBalanceContext
    {
        /// <summary>
        /// Gets the database context used by the current operation.
        /// </summary>
        /// <remarks>
        /// This is the base <see cref="DbContext"/> instance. Implementations that need
        /// access to the full model should cast to the concrete context type.
        /// </remarks>
        public required DbContext DbContext { get; init; }
        /// <summary>
        /// Gets the user identifier to calculate balance for.
        /// </summary>
        /// <remarks>
        /// When <see langword="null"/>, balances should be calculated for all users.
        /// When specified, the handler must include this user's balance in the returned dictionary.
        /// </remarks>
        public required int? UserId { get; init; }

        /// <summary>
        /// Gets the host group identifier.
        /// </summary>
        /// <remarks>
        /// When <see langword="null"/>, the balance is calculated without host group context.
        /// </remarks>
        public required int? HostGroupId { get; init; }
    }
}
