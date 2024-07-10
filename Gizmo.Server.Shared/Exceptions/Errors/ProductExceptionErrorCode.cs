using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Product error codes.
    /// </summary>
    public enum ProductExceptionErrorCode
    {
        /// <summary>
        /// Set when we try to perform an action on the wrong type of product.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_PRODUCT_INVALID_TYPE_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_PRODUCT_INVALID_TYPE_DESCRIPTION")]
        InvalidType = 0,
    }
}
