using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Points transaction exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Points)]
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
