﻿namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Deposit transactions error codes.
    /// </summary>
    public enum DepositExceptionErrorCode
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        Unspecified = 0,
        /// <summary>
        /// Set when we try to execute deposit transaction with zero amount.
        /// </summary>
        AmountZeroOrLess,
        /// <summary>
        /// Set when user has no funds to execute the transaction.
        /// </summary>
        InsufficientFunds,
        /// <summary>
        /// Set when deposit transaction would cause user into negative balance.
        /// </summary>
        NegativeBalanceNotAllowed,
        /// <summary>
        /// Set when user deposits are withheld for unpaid session time.
        /// </summary>
        DepositsWithheldForUnpaidSessions,
        /// <summary>
        /// Set when we try to void already voided deposit payment.
        /// </summary>
        AlreadyVoided,
    }
}
