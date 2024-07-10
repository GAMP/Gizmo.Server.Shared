using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Points transaction error codes.
    /// </summary>
    public enum PointTransactionExceptionErrorCode
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [Localized("UNSPECIFIED")]
        [Name("???", "EXCEPTION_ERROR_POINT_TRANSACTION_UNSPECIFIED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_POINT_TRANSACTION_UNSPECIFIED_DESCRIPTION")]
        Unspecified = 0,

        /// <summary>
        /// Set when we try to execute transaction with zero amount.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_POINT_TRANSACTION_AMOUNT_ZERO_OR_LESS_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_POINT_TRANSACTION_AMOUNT_ZERO_OR_LESS_DESCRIPTION")]
        AmountZeroOrLess = 1,

        /// <summary>
        /// Set when user has no funds to execute the transaction.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_POINT_TRANSACTION_INSUFFICIENT_FUNDS_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_POINT_TRANSACTION_INSUFFICIENT_FUNDS_DESCRIPTION")]
        InsufficientFunds = 2,

        /// <summary>
        /// Transaction type not supporeted.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_POINT_TRANSACTION_TRANSACTION_TYPE_NOT_SUPPORTED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_POINT_TRANSACTION_TRANSACTION_TYPE_NOT_SUPPORTED_DESCRIPTION")]
        TransactionTypeNotSupported = 3,
    }
}
