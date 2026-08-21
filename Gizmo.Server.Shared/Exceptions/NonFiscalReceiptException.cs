using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions;

/// <summary>
/// Represents a non-fiscal receipt generation or dispatch failure.
/// </summary>
[ExceptionFilterCode(ExceptionCode.NonFiscalReceipt)]
public sealed class NonFiscalReceiptException(NonFiscalReceiptExceptionErrorCode errorCode) : ErrorCodeExceptionBase<NonFiscalReceiptExceptionErrorCode>(errorCode)
{
}
