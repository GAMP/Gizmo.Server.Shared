﻿using Gizmo.Server.Exceptions.Attributes;
using Gizmo.Server.Exceptions.Errors;
using Gizmo.Server.Web.Api;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment exception.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ExceptionFilterCode(WebApiErrorCode.Payment)]
    public class PaymentException : PaymentExcpetionBase<PaymentErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        /// <param name="paymentMethodId">Payment method id.</param>
        public PaymentException(PaymentErrorCode errorCode, int paymentMethodId) : base(errorCode, paymentMethodId)
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
