﻿using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Order status exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.OrderStatus)]
    public class OrderStatusException : ErrorCodeExceptionBase<OrderStatusExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public OrderStatusException(OrderStatusExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected OrderStatusException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
