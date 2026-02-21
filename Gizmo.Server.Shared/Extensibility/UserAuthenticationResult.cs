using System.Security.Claims;
using Gizmo.Web.Api.Models;

namespace Gizmo.Server.Extensibility
{
    /// <summary>
    /// Represents the result of a user authentication attempt.
    /// </summary>
    /// <remarks>
    /// This is a mutable pipeline context that flows through multiple authentication stages.
    /// Each stage (authenticate, post-authenticate) can inspect and modify the result.
    /// Use the static factory methods to create instances.
    /// </remarks>
    public sealed class UserAuthenticationResult
    {
        private UserAuthenticationResult()
        {
        }

        /// <summary>
        /// Gets or sets whether the authentication succeeded.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Gets or sets the failure reason when authentication did not succeed.
        /// </summary>
        public AuthenticationFailureReason FailureReason { get; set; }

        /// <summary>
        /// Gets or sets the authenticated principal.
        /// </summary>
        /// <remarks>
        /// Populated on successful authentication. Post-authenticate handlers may modify
        /// the principal to add or remove claims.
        /// </remarks>
        public ClaimsPrincipal? Principal { get; set; }

        /// <summary>
        /// Gets or sets the user information fields that the client must provide after authentication.
        /// </summary>
        public UserInfoTypes RequiredInfo { get; set; }

        /// <summary>
        /// Gets the extensibility dictionary for passing arbitrary data between authentication stages.
        /// </summary>
        public IDictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Creates a successful authentication result.
        /// </summary>
        /// <param name="principal">The authenticated claims principal.</param>
        /// <param name="requiredInfo">Optional user information fields the client must provide.</param>
        public static UserAuthenticationResult Success(ClaimsPrincipal principal, UserInfoTypes requiredInfo = UserInfoTypes.None)
        {
            return new UserAuthenticationResult
            {
                Succeeded = true,
                Principal = principal,
                RequiredInfo = requiredInfo,
            };
        }

        /// <summary>
        /// Creates a failed authentication result.
        /// </summary>
        /// <param name="reason">The reason authentication failed.</param>
        public static UserAuthenticationResult Fail(AuthenticationFailureReason reason)
        {
            return new UserAuthenticationResult
            {
                FailureReason = reason,
            };
        }

        /// <summary>
        /// Creates a result indicating the handler cannot process this authentication request.
        /// The server should fall through to the next handler or internal authentication.
        /// </summary>
        public static UserAuthenticationResult NoResult() => new();
    }
}
