using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    public enum AssistanceRequestErrorCode
    {
        /// <summary>
        /// Another assistance request is already pending or being processed.
        /// </summary>
        [Name("Assistance request already pending", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_ANOTHER_PENDING_REQUEST_NAME")]
        [ExtendedDescription("Another assistance request is already pending or being processed", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_ANOTHER_PENDING_REQUEST_DESCRIPTION")]
        AlreadyPending = 0,

        /// <summary>
        /// Indicates that user is not logged in into host.
        /// </summary>
        /// <remarks>
        /// Host is required when creating assistance request.
        /// This error only occurs when assistance request is initiated by user himself.
        /// </remarks>
        [Name("Assistance request no host", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_NO_HOST_NAME")]
        [ExtendedDescription("Cannot create assistance request without host", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_NO_HOST_DESCRIPTION")]
        NoHost = 1,

        /// <summary>
        /// Indicates that it's not possible to transition to new state.
        /// For example an canceled request cant be transitioned to rejected state.
        /// </summary>
        [Name("Assistance request cannot change state", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_CANNOT_CHANGE_STATE_NAME")]
        [ExtendedDescription("Cannot change the assistance request state to the specified state", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_CANNOT_CHANGE_STATE_DESCRIPTION")]
        CantTransition = 2,

        /// <summary>
        /// Request timed out.
        /// </summary>
        [Name("Assistance request timed out", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_TIMED_OUT_NAME")]
        [ExtendedDescription("The assistance request operation was timed out", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_TIMED_OUT_DESCRIPTION")]
        TimedOut = 3,

        /// <summary>
        /// Indicates that user does not have any pending requests.
        /// </summary>
        [Name("No pending assistance request", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_NO_PENDING_REQUEST_NAME")]
        [ExtendedDescription("The user does not have any pending assistance requests", "EXCEPTION_ERROR_ASSISTANCE_REQUEST_NO_PENDING_REQUEST_DESCRIPTION")]
        NoPending = 4,
    }
}
