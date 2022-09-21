using Gizmo.Shared.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment request creation exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.PaymentRequest)]
    public sealed class PaymentRequestException : ErrorCodeExceptionBase<PaymentRequestExceptionErrorCode>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <param name="errorCode">Error code.</param>
        public PaymentRequestException(string message, PaymentRequestExceptionErrorCode errorCode) : base(message, errorCode)
        {
        }
        #endregion
    }
}
