namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of a code dispatch operation.
    /// </summary>
    public enum SendCodeResult
    {
        /// <summary>
        /// The code delivery failed.
        /// </summary>
        Error = 0,

        /// <summary>
        /// The code was delivered successfully.
        /// </summary>
        Sent = 1,

        /// <summary>
        /// The code delivery was accepted but will be completed asynchronously.
        /// The provider will notify the server via <see cref="IVerificationCallback"/> when delivery resolves.
        /// </summary>
        Deferred = 2,
    }
}
