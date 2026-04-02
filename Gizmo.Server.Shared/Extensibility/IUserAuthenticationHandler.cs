using System;
using Gizmo.Extensibility;
using Gizmo.Extensibility.Abstractions;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines the contract for handling user authentication.
    /// </summary>
    /// <remarks>
    /// Implementations are invoked by the server during the authentication phase.
    /// The implementing class must be decorated with
    /// <see cref="Gizmo.Extensibility.Abstractions.ModuleMetadataAttribute"/> so the server
    /// can identify the provider when mapping external identities to local users.
    /// <para>
    /// <see cref="HandleAuthenticateAsync"/> is called first to validate credentials.
    /// Return <see cref="UserAuthenticationResult.NoResult"/> to defer to the next handler
    /// or the server's internal authentication.
    /// </para>
    /// <para>
    /// On successful authentication the handler must populate the result principal with the
    /// following claims:
    /// <list type="table">
    /// <listheader><term>Claim</term><description>Requirement</description></listheader>
    /// <item>
    ///   <term><see cref="System.Security.Claims.ClaimTypes.NameIdentifier"/></term>
    ///   <description><b>Required.</b> Unique user identifier in the external provider.</description>
    /// </item>
    /// <item>
    ///   <term><see cref="System.Security.Claims.ClaimTypes.Name"/></term>
    ///   <description><b>Required.</b> Username for the local user account.</description>
    /// </item>
    /// <item>
    ///   <term><see cref="System.Security.Claims.ClaimTypes.Email"/></term>
    ///   <description>Optional. Email address; used when creating or updating the local user.</description>
    /// </item>
    /// <item>
    ///   <term><see cref="System.Security.Claims.ClaimTypes.GivenName"/></term>
    ///   <description>Optional. First name; used when creating or updating the local user.</description>
    /// </item>
    /// <item>
    ///   <term><see cref="System.Security.Claims.ClaimTypes.Surname"/></term>
    ///   <description>Optional. Last name; used when creating or updating the local user.</description>
    /// </item>
    /// </list>
    /// </para>
    /// <para>
    /// <see cref="HandlePostAuthenticateAsync"/> is called after authentication completes
    /// (regardless of which handler produced the result) to allow inspection or modification
    /// of the result — e.g. adding claims, overriding required info, or denying a user that
    /// passed credential validation.
    /// </para>
    /// </remarks>
    [IntegrationCapability("0ABC95C6-6441-4A64-ABCA-4BED0BEE2914")]
    public interface IUserAuthenticationHandler
    {
        /// <summary>
        /// Handles a user authentication request.
        /// </summary>
        /// <param name="request">The authentication request containing credentials and parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// An authentication result indicating success, failure, or no result.
        /// </returns>
        Task<UserAuthenticationResult> HandleAuthenticateAsync(
            UserAuthenticationRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Called after authentication completes, allowing the handler to inspect or modify the result.
        /// </summary>
        /// <param name="result">The mutable authentication result from the authenticate phase.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        Task HandlePostAuthenticateAsync(
            UserAuthenticationResult result,
            CancellationToken cancellationToken = default);
    }
}
