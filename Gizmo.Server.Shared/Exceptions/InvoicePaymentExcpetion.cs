using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Invoice payment exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.InvoicePayment)]
    public class InvoicePaymentExcpetion : PaymentExcpetionBase<InvoicePaymentExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        /// <param name="paymentMethodId">Payment method id.</param>
        public InvoicePaymentExcpetion(InvoicePaymentExceptionErrorCode errorCode, int paymentMethodId)
            : base(errorCode, paymentMethodId)
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public InvoicePaymentExcpetion(InvoicePaymentExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Serialization context.</param>
        protected InvoicePaymentExcpetion(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
