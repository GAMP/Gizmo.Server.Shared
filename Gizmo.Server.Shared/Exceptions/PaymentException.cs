﻿using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Payment)]
    public class PaymentException : PaymentExcpetionBase<PaymentExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        /// <param name="paymentMethodId">Payment method id.</param>
        public PaymentException(PaymentExceptionErrorCode errorCode, int paymentMethodId) : base(errorCode, paymentMethodId)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected PaymentException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
