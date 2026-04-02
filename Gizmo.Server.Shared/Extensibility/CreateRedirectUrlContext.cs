namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Provides context for creating a redirect URL for verification.
    /// </summary>
    public sealed class CreateRedirectUrlContext
    {
        /// <summary>
        /// Gets the token value identifying this verification operation.
        /// The provider embeds this as a nonce in the redirect URL.
        /// </summary>
        public required string TokenValue { get; init; }
    }
}
