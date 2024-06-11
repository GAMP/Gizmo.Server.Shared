using Gizmo.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Points transaction exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Points)]
    [Name("Points transaction error", "EXCEPTION_TYPE_POINT_TRANSACTION_NAME")]
    [ExtendedDescription("Points transaction related error", "EXCEPTION_TYPE_POINT_TRANSACTION_DESCRIPTION")]
    public class PointTransactionException : ErrorCodeExceptionBase<PointTransactionExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public PointTransactionException(PointTransactionExceptionErrorCode errorCode) : base(errorCode)
        {
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected PointTransactionException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
