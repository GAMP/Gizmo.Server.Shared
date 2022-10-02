using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Product exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Product)]
    public class ProductException : ErrorCodeExceptionBase<ProductExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public ProductException(ProductExceptionErrorCode errorCode) : base(errorCode)
        {
        }

        #endregion
    }
}
