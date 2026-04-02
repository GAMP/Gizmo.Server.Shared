namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of a verification callback from a provider.
    /// </summary>
    /// <remarks>
    /// This is a unified result type used by both redirect-based and dispatch-based verification flows.
    /// The provider populates the metadata dictionary with whatever identity information it collected
    /// (phone number, email, display name, etc.). The server determines how to process the result
    /// based on the associated session/token type.
    /// </remarks>
    public sealed class VerificationCallbackResult
    {
        /// <summary>
        /// Gets the token value identifying the operation.
        /// </summary>
        public required string TokenValue { get; init; }

        /// <summary>
        /// Gets the recipient's channel-specific identifier (e.g. chat ID, phone number, OAuth sub).
        /// </summary>
        public required string RecipientAddress { get; init; }

        /// <summary>
        /// Gets optional metadata provided by the verification provider.
        /// </summary>
        public IReadOnlyDictionary<VerificationCallbackMetadataKey, string>? Metadata { get; init; }
    }
}
