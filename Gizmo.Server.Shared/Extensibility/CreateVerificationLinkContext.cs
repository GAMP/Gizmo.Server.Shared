namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for creating a messenger verification link.
    /// </summary>
    public sealed class CreateVerificationLinkContext
    {
        /// <summary>
        /// Gets the token value identifying this verification operation.
        /// </summary>
        public required string TokenValue { get; init; }
    }
}
