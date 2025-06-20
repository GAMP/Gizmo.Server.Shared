using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    [ExceptionFilterCode(ExceptionCode.StockCount)]
    public sealed class StockCountException : ErrorCodeExceptionBase<StockCountErrorCodes>
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public StockCountException(StockCountErrorCodes errorCode) : base(errorCode)
        {
        }
    }
}
