using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Fiscal printer error codes.
    /// </summary>
    public enum FiscalPrinterExceptionErrorCode
    {
        /// <summary>
        /// Fiscal printer is not connected.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_NOT_CONNECTED")]
        [Name("Fiscal printer not connected", "EXCEPTION_ERROR_FISCAL_PRINTER_NOT_CONNECTED_NAME")]
        [ExtendedDescription("Cannot perform the action because the fiscal printer is not connected", "EXCEPTION_ERROR_FISCAL_PRINTER_NOT_CONNECTED_DESCRIPTION")]
        NotConnected = 0,

        /// <summary>
        /// Shift is expired.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_SHIFT_EXPIRED")]
        [Name("Fiscal printer shift expired", "EXCEPTION_ERROR_FISCAL_PRINTER_SHIFT_EXPIRED_NAME")]
        [ExtendedDescription("Cannot perform the action because the fiscal printer shift is expired", "EXCEPTION_ERROR_FISCAL_PRINTER_SHIFT_EXPIRED_DESCRIPTION")]
        ShiftExpired = 1,

        /// <summary>
        /// Shift is closed.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_SHIFT_CLOSED")]
        [Name("Fiscal printer shift closed", "EXCEPTION_ERROR_FISCAL_PRINTER_SHIFT_CLOSED_NAME")]
        [ExtendedDescription("Cannot perform the action because the fiscal printer shift is closed", "EXCEPTION_ERROR_FISCAL_PRINTER_SHIFT_CLOSED_DESCRIPTION")]
        ShiftClosed = 2,

        /// <summary>
        /// Fiscal printer driver error.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_DRIVER_ERROR")]
        [Name("Fiscal printer driver error", "EXCEPTION_ERROR_FISCAL_PRINTER_DRIVER_ERROR_NAME")]
        [ExtendedDescription("Cannot perform the action due to driver error", "EXCEPTION_ERROR_FISCAL_PRINTER_DRIVER_ERROR_DESCRIPTION")]
        DriverError = 3,

        /// <summary>
        /// Fiscal printer error.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_PRINTER_ERROR")]
        [Name("Fiscal printer printer error", "EXCEPTION_ERROR_FISCAL_PRINTER_PRINTER_ERROR_NAME")]
        [ExtendedDescription("Cannot perform the action due to printer error", "EXCEPTION_ERROR_FISCAL_PRINTER_PRINTER_ERROR_DESCRIPTION")]
        PrinterError = 4,

        /// <summary>
        /// Failed to generate a receipt.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_RECEIPT_GENERATE_ERROR")]
        [Name("Fiscal printer receipt generator error", "EXCEPTION_ERROR_FISCAL_PRINTER_RECEIPT_GENERATOR_ERROR_NAME")]
        [ExtendedDescription("Cannot perform the action due to receipt generator error", "EXCEPTION_ERROR_FISCAL_PRINTER_RECEIPT_GENERATOR_ERROR_DESCRIPTION")]
        ReceiptGenerateError = 5,

        /// <summary>
        /// No initial sale receipt was printed.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_NO_RECEIPT_ERROR")]
        [Name("Fiscal printer no receipt", "EXCEPTION_ERROR_FISCAL_PRINTER_NO_RECEIPT_NAME")]
        [ExtendedDescription("Cannot perform the action because no initial sale receipt was printed", "EXCEPTION_ERROR_FISCAL_PRINTER_NO_RECEIPT_DESCRIPTION")]
        NoReceipt = 6,

        /// <summary>
        /// Return receipt can't be generated since there are multiple tax systems.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_MULTIPLE_TAX_SYSTEMS")]
        [Name("Fiscal printer multiple tax systems", "EXCEPTION_ERROR_FISCAL_PRINTER_MULTIPLE_TAX_SYSTEMS_NAME")]
        [ExtendedDescription("Cannot perform the action due to multiple tax systems", "EXCEPTION_ERROR_FISCAL_PRINTER_MULTIPLE_TAX_SYSTEMS_DESCRIPTION")]
        MultipleTaxSystems = 7,

        /// <summary>
        /// Return receipt can't be generated since there are mixed deposits with other payment methods.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_DEPOSIT_MIXED")]
        [Name("Fiscal printer deposits mixed with other payment methods", "EXCEPTION_ERROR_FISCAL_PRINTER_DEPOSITS_MIXED_WITH_OTHER_PAYMENT_METHODS_NAME")]
        [ExtendedDescription("Cannot perform the action because deposits are mixed with other payment methods", "EXCEPTION_ERROR_FISCAL_PRINTER_DEPOSITS_MIXED_WITH_OTHER_PAYMENT_METHODS_DESCRIPTION")]
        DepositsMixedWithOtherPayments = 8,

        /// <summary>
        /// Return receipt can't be generated since there is a payment from deposits that doesn't match the amount of services.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_DEPOSIT_NOT_MATCH_SERVICES")]
        [Name("Fiscal printer deposits do not match services", "EXCEPTION_ERROR_FISCAL_PRINTER_DESPOSITS_DO_NOT_MATCH_SERVICES_NAME")]
        [ExtendedDescription("Cannot perform the action because deposits do not match services", "EXCEPTION_ERROR_FISCAL_PRINTER_DESPOSITS_DO_NOT_MATCH_SERVICES_DESCRIPTION")]
        DepositsNotMatchServices = 9,

        /// <summary>
        /// Partially paid orders not allowed.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_PARTIAL_PAYMENT_NOT_ALLOWED")]
        [Name("Fiscal printer partially paid not allowed", "EXCEPTION_ERROR_FISCAL_PRINTER_PARTIALLY_PAID_NOT_ALLOWED_NAME")]
        [ExtendedDescription("Cannot perform the action because partially paid invoices are not allowed", "EXCEPTION_ERROR_FISCAL_PRINTER_PARTIALLY_PAID_NOT_ALLOWED_DESCRIPTION")]
        PartiallyPaidNotAllowed = 10,

        /// <summary>
        /// Mulitple payment methods not allowed.
        /// </summary>
        [Localized("FISCAL_PRINTER_ERROR_MULTIPLE_PAYMENT_METHODS_NOT_ALLOWED")]
        [Name("Fiscal printer multiple payment methods not allowed", "EXCEPTION_ERROR_FISCAL_PRINTER_MULTIPLE_PAYMENT_METHODS_NOT_ALLOWED_NAME")]
        [ExtendedDescription("Cannot perform the action because multiple payment methods are not allowed", "EXCEPTION_ERROR_FISCAL_PRINTER_MULTIPLE_PAYMENT_METHODS_NOT_ALLOWED_DESCRIPTION")]
        MultiplePaymentMethodsNotAllowed = 11,
    }
}
