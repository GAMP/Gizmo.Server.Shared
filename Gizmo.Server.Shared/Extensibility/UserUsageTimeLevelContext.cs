using System;
using Microsoft.EntityFrameworkCore;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for a user usage time-level request.
    /// </summary>
    public sealed class UserUsageTimeLevelContext
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
        /// Gets the user identifier to compute time levels for.
        /// </summary>
        public required int UserId { get; init; }

        /// <summary>
        /// Gets the host group identifier.
        /// </summary>
        /// <remarks>
        /// When <see langword="null"/>, the time levels are computed without host group context.
        /// </remarks>
        public required int? HostGroupId { get; init; }

        /// <summary>
        /// Gets the starting time for the projection.
        /// </summary>
        /// <remarks>
        /// When <see langword="null"/>, the implementation should use the current time.
        /// </remarks>
        public required DateTime? StartTime { get; init; }
    }
}
