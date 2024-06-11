using Gizmo.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Stock exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Stock)]
    [Name("Stock error", "EXCEPTION_TYPE_STOCK_NAME")]
    [ExtendedDescription("Stock related error", "EXCEPTION_TYPE_STOCK_DESCRIPTION")]
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
