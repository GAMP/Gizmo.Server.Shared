using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// User group error codes.
    /// </summary>
    public enum UserGroupExceptionErrorCode
    {
        /// <summary>
        /// Set when we try to perform an action on the wrong type of user group.
        /// </summary>
        [Name("User group invalid type", "EXCEPTION_ERROR_USER_GROUP_INVALID_TYPE_NAME")]
        [ExtendedDescription("Cannot perform the action because the user group type is invalid", "EXCEPTION_ERROR_USER_GROUP_INVALID_TYPE_DESCRIPTION")]
        InvalidType = 0,
    }
}
