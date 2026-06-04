using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Refund exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Refund)]
    public sealed class RefundException : ErrorCodeExceptionBase<RefundExceptionErrorCode>
    {
        public RefundException(RefundExceptionErrorCode code) : base(code) { }
    }
}
