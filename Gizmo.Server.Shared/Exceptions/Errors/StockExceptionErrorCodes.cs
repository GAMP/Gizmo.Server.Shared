using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Stock error codes.
    /// </summary>
    public enum StockExceptionErrorCodes
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [Name("Stock transaction unspecified error", "EXCEPTION_ERROR_STOCK_UNSPECIFIED_NAME")]
        [ExtendedDescription("Unspecified error while executing stock transaction", "EXCEPTION_ERROR_STOCK_UNSPECIFIED_DESCRIPTION")]
        Unspecified = 0,

        /// <summary>
        /// Set when we try to modify stock level of a product that has stock disabled.
        /// </summary>
        [Name("Stock disabled", "EXCEPTION_ERROR_STOCK_STOCK_DISABLED_NAME")]
        [ExtendedDescription("Cannot modify the stock level of a product that has stock disabled", "EXCEPTION_ERROR_STOCK_STOCK_DISABLED_DESCRIPTION")]
        StockDisabled = 1,

        /// <summary>
        /// Set when we try to create a stock transaction with zero amount.
        /// </summary>
        [Name("Stock transaction zero amount", "EXCEPTION_ERROR_STOCK_ZERO_AMOUNT_NAME")]
        [ExtendedDescription("Cannot create a stock transaction with zero amount", "EXCEPTION_ERROR_STOCK_ZERO_AMOUNT_DESCRIPTION")]
        ZeroAmount = 2,

        /// <summary>
        /// Set when we have a TargetDifferentProduct flag on product stock option while not actually targeting specific product.
        /// </summary>
        [Name("Stock target product not set", "EXCEPTION_ERROR_STOCK_TARGET_PRODUCT_NOT_SET_NAME")]
        [ExtendedDescription("Target different product option is set on the product, but not the target product", "EXCEPTION_ERROR_STOCK_TARGET_PRODUCT_NOT_SET_DESCRIPTION")]
        TargetProductNotSet = 3,

        /// <summary>
        /// The product configuration does not allow the specific transaction.
        /// </summary>
        [Name("Stock transaction invalid type", "EXCEPTION_ERROR_STOCK_INVALID_TYPE_NAME")]
        [ExtendedDescription("The product configuration does not allow the specific stock transaction", "EXCEPTION_ERROR_STOCK_INVALID_TYPE_DESCRIPTION")]
        InvalidType = 4,

        /// <summary>
        /// Product is out of stock.
        /// </summary>
        [Name("Out of stock", "EXCEPTION_ERROR_STOCK_OUT_OF_STOCK_NAME")]
        [ExtendedDescription("The product is out of stock", "EXCEPTION_ERROR_STOCK_OUT_OF_STOCK_DESCRIPTION")]
        OutOfStock = 5,
    }
}
