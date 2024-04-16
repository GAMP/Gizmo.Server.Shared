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
        Error = 0,
        /// <summary>
        /// Invalid host id was provided.
        /// </summary>
        InvalidHostId = 1,
        /// <summary>
        /// Host is not connected.
        /// </summary>
        HostNotConnected = 2,
        /// <summary>
        /// Session initiation error.
        /// </summary>
        SessionInitiationError = 3,
        /// <summary>
        /// Not supported by client host.s
        /// </summary>
        NotSupported = 4,
    }
}
