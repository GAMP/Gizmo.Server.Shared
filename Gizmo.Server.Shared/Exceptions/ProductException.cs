using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Product exception.
    /// </summary>
    [ExceptionFilterCode(WebApiErrorCode.Product)]
    public class ProductException : ErrorCodeExceptionBase<ProductErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public ProductException(ProductErrorCode errorCode) : base(errorCode)
        {
        }

        #endregion
    }
}
