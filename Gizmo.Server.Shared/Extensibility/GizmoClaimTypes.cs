namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Defines claim types used by the Gizmo authentication pipeline.
    /// </summary>
    /// <remarks>
    /// <see cref="IUserAuthenticationHandler"/> implementations should use these constants
    /// when populating claims on <see cref="UserAuthenticationResult.Principal"/>.
    /// </remarks>
    public static class GizmoClaimTypes
    {
        /// <summary>
        /// The unique identifier of the user in the external authentication provider.
        /// </summary>
        /// <remarks>
        /// This claim is required on successful authentication from an external handler.
        /// The server uses it to resolve or create a local mapped user.
        /// The value is preserved on the local principal after mapping, allowing
        /// downstream code to correlate the local user with the external identity.
        /// </remarks>
        public const string ExternalId = "gizmo:external_id";

        /// <summary>
        /// The name of the external authentication provider that produced the identity.
        /// </summary>
        /// <remarks>
        /// Optional but recommended. Allows the server to distinguish between
        /// multiple external providers when mapping users.
        /// </remarks>
        public const string ExternalProvider = "gizmo:external_provider";

        /// <summary>
        /// Prefix used for user attribute names that map external authentication providers
        /// to local users.
        /// </summary>
        /// <remarks>
        /// The full attribute name is composed as <c>AuthHandler:{ModuleGuid:N}</c>
        /// where the GUID comes from the handler's <see cref="Gizmo.Extensibility.Abstractions.ModuleMetadataAttribute.ModuleGuid"/>.
        /// The <c>N</c> format (32 hex digits, no dashes) keeps the total length within
        /// the 45-character attribute name limit.
        /// </remarks>
        public const string AuthHandlerAttributePrefix = "AuthHandler:";
    }
}
