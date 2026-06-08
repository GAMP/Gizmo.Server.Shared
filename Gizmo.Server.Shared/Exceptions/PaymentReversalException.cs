using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment reversal exception.
    /// </summary>
    /// <remarks>
    /// Thrown when an electronic payment reversal cannot be performed.
    /// </remarks>
    [ExceptionFilterCode(ExceptionCode.PaymentReversal)]
    public sealed class PaymentReversalException : ErrorCodeExceptionBase<PaymentReversalExceptionErrorCode>
    {
        public PaymentReversalException(PaymentReversalExceptionErrorCode code) : base(code) { }
    }
}
