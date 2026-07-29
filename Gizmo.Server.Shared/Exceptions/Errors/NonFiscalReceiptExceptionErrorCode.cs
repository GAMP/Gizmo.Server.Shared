namespace Gizmo.Server.Exceptions;

/// <summary>
/// Non-fiscal receipt generation and dispatch error codes.
/// </summary>
public enum NonFiscalReceiptExceptionErrorCode
{
    InvalidRequest = 0,
    NotFound = 1,
    EntityTypeMismatch = 2,
    ConfigurationFailed = 3,
    GenerationFailed = 4,
    TransportFailed = 5,
    DispatchOutcomeUnknown = 6
}
