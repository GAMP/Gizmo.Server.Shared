using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Product exception.
    /// </summary>
    [ExceptionFilterCode(WebApiErrorCode.Product)]
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
