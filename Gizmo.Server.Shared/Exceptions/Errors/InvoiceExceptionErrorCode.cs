using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Invoice error codes.
    /// </summary>
    public enum InvoiceExceptionErrorCode
    {
        /// <summary>
        /// Set when invoice status is already set to paid and we try to execute a payment on it.
        /// </summary>
        [Name("Invoice already paid", "EXCEPTION_ERROR_INVOICE_ALREADY_PAID_NAME")]
        [ExtendedDescription("Cannot execute payment on invoice that is already paid", "EXCEPTION_ERROR_INVOICE_ALREADY_PAID_DESCRIPTION")]
        AlreadyPaid,

        /// <summary>
        /// Set when we try to fully repay an invoice with amount less than outstanding amount.
        /// </summary>
        [Name("Amount is less than outstanding", "EXCEPTION_ERROR_INVOICE_AMOUNT_LESS_THAN_OUTSTANDING_NAME")]
        [ExtendedDescription("Cannot repay an invoice with amount less than outstanding amount", "EXCEPTION_ERROR_INVOICE_AMOUNT_LESS_THAN_OUTSTANDING_DESCRIPTION")]
        AmountLessThanOutstanding,

        /// <summary>
        /// Set when we try to perform an action on a void invoice.
        /// </summary>
        [Name("Void invoice", "EXCEPTION_ERROR_INVOICE_VOID_NAME")]
        [ExtendedDescription("Cannot perform the action on a void invoice", "EXCEPTION_ERROR_INVOICE_VOID_DESCRIPTION")]
        Void,

        /// <summary>
        /// Set when we try to create an invoice for a user with disabled credit.
        /// </summary>
        [Name("User with no credit", "EXCEPTION_ERROR_INVOICE_NO_CREDIT_NAME")]
        [ExtendedDescription("Cannot create an invoice for a user with disabled credit", "EXCEPTION_ERROR_INVOICE_NO_CREDIT_DESCRIPTION")]
        NoCredit,

        /// <summary>
        /// Set when invoice would cause user to exceed credit limit.
        /// </summary>
        [Name("User credit limit reached", "EXCEPTION_ERROR_INVOICE_CREDIT_LIMIT_REACHED_NAME")]
        [ExtendedDescription("The invoice would cause user to exceed credit limit", "EXCEPTION_ERROR_INVOICE_CREDIT_LIMIT_REACHED_DESCRIPTION")]
        CreditLimitReached,
    }
}
