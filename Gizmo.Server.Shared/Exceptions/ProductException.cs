using System.ComponentModel.DataAnnotations;
using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Product exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Product)]
    [Name("Product error", "EXCEPTION_TYPE_PRODUCT_NAME")]
    [ExtendedDescription("Product related error", "EXCEPTION_TYPE_PRODUCT_DESCRIPTION")]
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
