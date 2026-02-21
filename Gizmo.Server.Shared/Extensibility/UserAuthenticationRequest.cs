namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents a user authentication request.
    /// </summary>
    /// <remarks>
    /// The <see cref="Parameters"/> dictionary carries authentication data.
    /// Standard keys include "USERNAME" and "PASSWORD", but plugins may define
    /// custom keys for alternative authentication methods (e.g. "CARD_ID", "SCAN_DATA").
    /// </remarks>
    public sealed class UserAuthenticationRequest
    {
        /// <summary>
        /// Gets the authentication parameters.
        /// </summary>
        public IDictionary<string, object> Parameters { get; init; } = new Dictionary<string, object>();
    }
}
