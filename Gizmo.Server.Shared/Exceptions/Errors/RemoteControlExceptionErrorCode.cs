using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions.Errors
{
    /// <summary>
    /// Remote control exception codes.
    /// </summary>
    public enum RemoteControlExceptionErrorCode
    {
        /// <summary>
        /// Generic error.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_REMOTE_CONTROL_ERROR_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_REMOTE_CONTROL_ERROR_DESCRIPTION")]
        Error = 0,

        /// <summary>
        /// Invalid host id was provided.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_REMOTE_CONTROL_INVALID_HOST_ID_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_REMOTE_CONTROL_INVALID_HOST_ID_DESCRIPTION")]
        InvalidHostId = 1,

        /// <summary>
        /// Host is not connected.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_REMOTE_CONTROL_HOST_NOT_CONNECTED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_REMOTE_CONTROL_HOST_NOT_CONNECTED_DESCRIPTION")]
        HostNotConnected = 2,

        /// <summary>
        /// Session initiation error.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_REMOTE_CONTROL_SESSION_INITIATION_ERROR_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_REMOTE_CONTROL_SESSION_INITIATION_ERROR_DESCRIPTION")]
        SessionInitiationError = 3,

        /// <summary>
        /// Not supported by client host.s
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_REMOTE_CONTROL_NOT_SUPPORTED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_REMOTE_CONTROL_NOT_SUPPORTED_DESCRIPTION")]
        NotSupported = 4,
    }
}
