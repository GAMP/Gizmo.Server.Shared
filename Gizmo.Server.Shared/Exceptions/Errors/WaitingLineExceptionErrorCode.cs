using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Waiting line error codes.
    /// </summary>
    public enum WaitingLineExceptionErrorCode
    {
        /// <summary>
        /// Already in waiting line.
        /// </summary>
        [Localized("WAITING_LINE_ERROR_ALREADY_IN_WAITING_LINE")]
        [Name("Already in waiting line", "EXCEPTION_ERROR_WAITING_LINE_ALREADY_IN_WAITING_LINE_NAME")]
        [ExtendedDescription("User is already in waiting line", "EXCEPTION_ERROR_WAITING_LINE_ALREADY_IN_WAITING_LINE_DESCRIPTION")]
        AlreadyInWaitingLine = 0,

        /// <summary>
        /// Not in waiting line.
        /// </summary>
        [Localized("WAITING_LINE_ERROR_NOT_IN_WAITING_LINE")]
        [Name("Not in waiting line", "EXCEPTION_ERROR_WAITING_LINE_NOT_IN_WAITING_LINE_NAME")]
        [ExtendedDescription("User is not in waiting line", "EXCEPTION_ERROR_WAITING_LINE_NOT_IN_WAITING_LINE_DESCRIPTION")]
        NotInWaitingLine = 1,

        /// <summary>
        /// Disallowed host group.
        /// </summary>
        [Localized("WAITING_LINE_ERROR_DISALLOWED_HOST_GROUP")]
        [Name("Waiting line disallowed host group", "EXCEPTION_ERROR_WAITING_LINE_DISALLOWED_HOST_GROUP_NAME")]
        [ExtendedDescription("The specified host group is not allowed for the specified user", "EXCEPTION_ERROR_WAITING_LINE_DISALLOWED_HOST_GROUP_DESCRIPTION")]
        DisallowedHostGroup = 2,

        /// <summary>
        /// Not active.
        /// </summary>
        [Localized("WAITING_LINE_ERROR_NOT_ACTIVE")]
        [Name("Waiting line is not active", "EXCEPTION_ERROR_WAITING_LINE_NOT_ACTIVE_NAME")]
        [ExtendedDescription("Cannot perform the action because the waiting line is not active", "EXCEPTION_ERROR_WAITING_LINE_NOT_ACTIVE_DESCRIPTION")]
        NotActive = 3,

        /// <summary>
        /// Already logged in.
        /// </summary>
        [Localized("WAITING_LINE_ERROR_ALREADY_LOGGED_IN")]
        [Name("User is already logged in", "EXCEPTION_ERROR_WAITING_LINE_ALREADY_LOGGED_IN_NAME")]
        [ExtendedDescription("Cannot perform the action because the waiting line is already logged in", "EXCEPTION_ERROR_WAITING_LINE_ALREADY_LOGGED_IN_DESCRIPTION")]
        AlreadyLoggedIn = 4,
    }
}
