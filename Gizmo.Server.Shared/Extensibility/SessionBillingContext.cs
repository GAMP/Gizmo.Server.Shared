using Microsoft.EntityFrameworkCore;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for a session billing request.
    /// </summary>
    public sealed class SessionBillingContext
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
        /// Gets the user identifier being billed.
        /// </summary>
        public required int UserId { get; init; }

        /// <summary>
        /// Gets the billing span in seconds.
        /// </summary>
        public required double SpanSeconds { get; init; }

        /// <summary>
        /// Gets whether negative balance is allowed for this user.
        /// </summary>
        /// <remarks>
        /// Determined by user group settings or explicit user-level override.
        /// </remarks>
        public required bool IsNegativeAllowed { get; init; }

        /// <summary>
        /// Gets the user's credit limit.
        /// </summary>
        public required decimal CreditLimit { get; init; }

        /// <summary>
        /// Gets the user session identifier being billed.
        /// </summary>
        public required int UserSessionId { get; init; }

        /// <summary>
        /// Gets the host group identifier.
        /// </summary>
        public int? HostGroupId { get; init; }

        /// <summary>
        /// Gets the user group identifier.
        /// </summary>
        public int? UserGroupId { get; init; }

        /// <summary>
        /// Gets the bill profile identifier.
        /// </summary>
        public int? BillProfileId { get; init; }

        /// <summary>
        /// Gets the time of billing execution (UTC).
        /// </summary>
        public required DateTime CurrentTime { get; init; }
    }
}
