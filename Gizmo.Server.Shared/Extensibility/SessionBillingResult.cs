namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of a session billing operation.
    /// </summary>
    public sealed class SessionBillingResult
    {
        /// <summary>
        /// Gets whether the user should be logged out after billing.
        /// </summary>
        public required bool ShouldLogout { get; init; }
    }
}
