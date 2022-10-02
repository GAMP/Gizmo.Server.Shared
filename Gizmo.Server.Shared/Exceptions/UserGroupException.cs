using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// User group exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.UserGroup)]
    public class UserGroupException : ErrorCodeExceptionBase<UserGroupExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public UserGroupException(UserGroupExceptionErrorCode errorCode) : base(errorCode)
        {
        }

        #endregion
    }
}
