using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Deposit transactions error codes.
    /// </summary>
    public enum DepositExceptionErrorCode
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [Name("Deposit transaction unspecified error", "EXCEPTION_ERROR_DEPOSIT_UNSPECIFIED_NAME")]
        [ExtendedDescription("Unspecified error while executing deposit transaction", "EXCEPTION_ERROR_DEPOSIT_UNSPECIFIED_DESCRIPTION")]
        Unspecified = 0,

        /// <summary>
        /// Set when we try to execute deposit transaction with zero amount.
        /// </summary>
        [Name("Deposit transaction amount zero or less", "EXCEPTION_ERROR_DEPOSIT_AMOUNT_ZERO_OR_LESS_NAME")]
        [ExtendedDescription("Cannot execute deposit transaction with amount zero or less", "EXCEPTION_ERROR_DEPOSIT_AMOUNT_ZERO_OR_LESS_DESCRIPTION")]
        AmountZeroOrLess,

        /// <summary>
        /// Set when user has no funds to execute the transaction.
        /// </summary>
        [Name("Deposit transaction insufficent funds", "EXCEPTION_ERROR_DEPOSIT_INSUFFICIENT_FUNDS_NAME")]
        [ExtendedDescription("The user has no funds to execute the deposit transaction", "EXCEPTION_ERROR_DEPOSIT_INSUFFICIENT_FUNDS_DESCRIPTION")]
        InsufficientFunds,

        /// <summary>
        /// Set when deposit transaction would cause user into negative balance.
        /// </summary>
        [Name("Deposit transaction negative balance not allowed", "EXCEPTION_ERROR_DEPOSIT_NEGATIVE_BALANCE_NOT_ALLOWED_NAME")]
        [ExtendedDescription("The deposit transaction would cause user into negative balance", "EXCEPTION_ERROR_DEPOSIT_NEGATIVE_BALANCE_NOT_ALLOWED_DESCRIPTION")]
        NegativeBalanceNotAllowed,

        /// <summary>
        /// Set when user deposits are withheld for unpaid session time.
        /// </summary>
        [Name("Deposits withheld for unpaid sessions", "EXCEPTION_ERROR_DEPOSIT_DEPOSITS_WITHELD_FOR_UNPAID_SESSIONS_NAME")]
        [ExtendedDescription("User deposits are withheld for unpaid session time", "EXCEPTION_ERROR_DEPOSIT_DEPOSITS_WITHELD_FOR_UNPAID_SESSIONS_DESCRIPTION")]
        DepositsWithheldForUnpaidSessions,

        /// <summary>
        /// Set when we try to void already voided deposit payment.
        /// </summary>
        [Name("Deposit already voided", "EXCEPTION_ERROR_DEPOSIT_ALREADY_VOIDED_NAME")]
        [ExtendedDescription("The deposit is already voided", "EXCEPTION_ERROR_DEPOSIT_ALREADY_VOIDED_DESCRIPTION")]
        AlreadyVoided,
    }
}
