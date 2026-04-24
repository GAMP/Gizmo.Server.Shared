using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gizmo.Extensibility;
using Gizmo.Extensibility.Abstractions;
using Gizmo.Web.Api.Models;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for overriding the user usage time-level computation.
    /// </summary>
    /// <remarks>
    /// Implementations can replace the default time-level projection (time offers, time
    /// fixed products, billing rates) with a custom result. Used by plugins that model
    /// time differently from the built-in billing concepts — e.g. unlimited/library-style
    /// access with queue-driven bounding.
    /// <para>
    /// <see cref="HandleAsync"/> returns a non-null enumerable to replace the default
    /// computation entirely. Return <see langword="null"/> to let the default logic run.
    /// </para>
    /// </remarks>
    [IntegrationCapability("7A1F3D8B-2E6C-4A5D-9F81-3B4E2C5A8F10")]
    public interface IUserUsageTimeLevelHandler
    {
        /// <summary>
        /// Handles the user usage time-level request, optionally replacing the default
        /// computation.
        /// </summary>
        /// <param name="context">The time-level request context.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// An enumerable of <see cref="UserUsageTimeLevelModel"/> entries that fully
        /// describe the user's time projection, or <see langword="null"/> to let the
        /// default computation proceed.
        /// </returns>
        ValueTask<IEnumerable<UserUsageTimeLevelModel>?> HandleAsync(
            UserUsageTimeLevelContext context,
            CancellationToken cancellationToken = default);
    }
}
