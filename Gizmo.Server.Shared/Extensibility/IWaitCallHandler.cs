using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for verifying a user by an incoming call.
    /// </summary>
    /// <remarks>
    /// Integration capability <see cref="Gizmo.Extensibility.IntegrationCapabilities.WaitCall"/> —
    /// the reverse of a flash call: the provider supplies a phone number and the user calls it
    /// (typically a dropped/unanswered call) to prove possession of their phone; the provider
    /// detects the incoming caller id and reports the verification outcome.
    /// <para>
    /// Marker interface for capability discovery — the operation contract will be added
    /// together with the wait call verification flow.
    /// </para>
    /// </remarks>
    [IntegrationCapability("8D5F3B29-6E4A-4C71-9B2D-5A8E1F6C4D93")]
    public interface IWaitCallHandler
    {
    }
}
