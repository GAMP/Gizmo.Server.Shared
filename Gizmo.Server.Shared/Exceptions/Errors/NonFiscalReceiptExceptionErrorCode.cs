namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Non-fiscal receipt generation and dispatch error codes.
    /// </summary>
    public enum NonFiscalReceiptExceptionErrorCode
    {
        /// <summary>
        /// The print request is invalid.
        /// </summary>
        InvalidRequest = 0,

        /// <summary>
        /// The requested receipt entity was not found.
        /// </summary>
        NotFound = 1,

        /// <summary>
        /// The requested entity does not match the requested receipt kind.
        /// </summary>
        EntityTypeMismatch = 2,

        /// <summary>
        /// Receipt configuration could not be loaded or validated.
        /// </summary>
        ConfigurationFailed = 3,

        /// <summary>
        /// Receipt generation failed.
        /// </summary>
        GenerationFailed = 4,

        /// <summary>
        /// The receipt could not be sent to the printer.
        /// </summary>
        TransportFailed = 5,

        /// <summary>
        /// The printer dispatch outcome is unknown.
        /// </summary>
        DispatchOutcomeUnknown = 6,
    }
}
