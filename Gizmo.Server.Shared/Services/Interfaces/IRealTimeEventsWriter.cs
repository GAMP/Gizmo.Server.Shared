using Gizmo.Web.Api.Messaging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Gizmo.Server.Services
{
    /// <summary>
    /// Plugin-facing real time events writer.
    /// </summary>
    /// <remarks>
    /// Exposes the API event write operations of <see cref="IRealTimeEventsService"/> without
    /// leaking server-internal concerns (companion messaging, channel readers).
    /// </remarks>
    public interface IRealTimeEventsWriter
    {
        /// <summary>
        /// Writes event messages.
        /// </summary>
        /// <param name="messages">Event messages.</param>
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        ValueTask WriteAsync(IEnumerable<IAPIEventMessage> messages);

        /// <summary>
        /// Writes event messages.
        /// </summary>
        /// <param name="messages">Event messages.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        ValueTask WriteAsync(IEnumerable<IAPIEventMessage> messages, CancellationToken cancellationToken = default);

        /// <summary>
        /// Writes event message.
        /// </summary>
        /// <param name="eventMessage">Event message.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <exception cref="OperationCanceledException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        ValueTask WriteAsync(IAPIEventMessage eventMessage, CancellationToken cancellationToken = default);

        /// <summary>
        /// Writes event message.
        /// </summary>
        /// <param name="eventMessage">Event message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        ValueTask WriteAsync(IAPIEventMessage eventMessage);
    }
}
