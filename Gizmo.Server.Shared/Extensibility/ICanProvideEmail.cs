using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Marker interface indicating that the integration can provide a verified email address.
    /// </summary>
    /// <remarks>
    /// Providers that implement this interface will return an email address in the
    /// <see cref="VerificationCallbackResult.Metadata"/> dictionary under the
    /// <see cref="VerificationCallbackMetadataKey.Email"/> key when a redirect flow completes.
    /// </remarks>
    [IntegrationCapability("1E8A2E58-D0E4-41E2-A834-C4BC595DD04E")]
    public interface ICanProvideEmail
    {
    }
}
