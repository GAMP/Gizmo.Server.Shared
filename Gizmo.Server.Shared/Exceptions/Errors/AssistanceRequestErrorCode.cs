namespace Gizmo.Server.Exceptions
{
    public enum AssistanceRequestErrorCode
    {
        /// <summary>
        /// Another assistance request is already pending or being processed.
        /// </summary>
        AlreadyPending = 0,
        /// <summary>
        /// Indicates that user is not logged in into host.
        /// </summary>
        /// <remarks>
        /// Host is required when creating assistance request.
        /// This error only occurs when assistance request is initiated by user himself.
        /// </remarks>
        NoHost = 1,
        /// <summary>
        /// Indicates that its not possible to transition to new state.
        /// For example an canceled request cant be transitioned to rejected state.
        /// </summary>
        CantTransition = 2,
        /// <summary>
        /// Request timed out.
        /// </summary>
        TimedOut = 3,
        /// <summary>
        /// Indicates that user does not have any pending requests.
        /// </summary>
        NoPending = 4,
    }
}
