using Gizmo.Server.Exceptions.Attributes;
using Gizmo.Server.Exceptions.Errors;
using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Stock exception.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ExceptionFilterCode(WebApiErrorCode.Stock)]
    public class StockException : ErrorCodeExceptionBase<StockErrorCodes>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public StockException(StockErrorCodes errorCode) : base(errorCode)
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
