using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Invoice payment error code.
    /// </summary>
    public enum InvoicePaymentExceptionErrorCode
    {
        /// <summary>
        /// Set on unspecified error.
        /// </summary>
        [Localized("UNSPECIFIED")]
        [Name("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_UNSPECIFIED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_UNSPECIFIED_DESCRIPTION")]
        Unspecified = 0,

        /// <summary>
        /// Set when invoice payment amount equals zero.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_AMOUNT_ZERO_OR_LESS_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_AMOUNT_ZERO_OR_LESS_DESCRIPTION")]
        AmountZeroOrLess,

        /// <summary>
        /// Set when outstanding amount is zero.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_OUTSTANDING_AMOUNT_ZERO_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_OUTSTANDING_AMOUNT_ZERO_DESCRIPTION")]
        OutstandingAmountZero,

        /// <summary>
        /// Set when outstanding amount is less than the payment amount.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_OUTSTANDING_AMOUNT_LESS_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_INVOICE_PAYMENT_OUTSTANDING_AMOUNT_LESS_DESCRIPTION")]
        OutstandingAmountLess,
    }
}
