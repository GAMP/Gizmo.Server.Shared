using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// User group exception.
    /// </summary>
    [ExceptionFilterCode(WebApiErrorCode.UserGroup)]
    public class UserGroupException : ErrorCodeExceptionBase<UserGroupErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public UserGroupException(UserGroupErrorCode errorCode) : base(errorCode)
        {
        }

        #endregion
    }
}
