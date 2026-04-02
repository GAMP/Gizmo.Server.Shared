using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Marker interface indicating that the integration can provide a verified phone number.
    /// </summary>
    /// <remarks>
    /// Providers that implement this interface will return a phone number in the
    /// <see cref="VerificationCallbackResult.Metadata"/> dictionary under the
    /// <see cref="VerificationCallbackMetadataKey.PhoneNumber"/> key when a redirect flow completes.
    /// </remarks>
    [IntegrationCapability("06C4D84C-843D-43BB-BB84-14FD560C962A")]
    public interface ICanProvidePhone
    {
    }
}
