using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Stock exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Stock)]
    public class StockException : ErrorCodeExceptionBase<StockExceptionErrorCodes>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public StockException(StockExceptionErrorCodes errorCode) : base(errorCode)
        {
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected StockException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
