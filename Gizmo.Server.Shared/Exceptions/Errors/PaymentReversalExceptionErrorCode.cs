using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment reversal error codes.
    /// </summary>
    /// <remarks>
    /// These describe why an electronic payment reversal cannot be performed. Reversal applies
    /// only to payments made over a payment-provider rail (card terminal / external PSP); internal
    /// methods (cash, deposit, points) have no rail to reverse.
    /// </remarks>
    public enum PaymentReversalExceptionErrorCode
    {
        /// <summary>
        /// Set on unspecified reversal error.
        /// </summary>
        [Name("Payment reversal unspecified error")]
        [ExtendedDescription("Unspecified error while reversing payment")]
        Unspecified = 0,

        /// <summary>
        /// Set when the payment has no payment provider and therefore cannot be electronically reversed.
        /// </summary>
        /// <remarks>
        /// Internal methods such as cash, deposit and points are returned by the caller (drawer / balance),
        /// not reversed over a provider rail.
        /// </remarks>
        [Name("Payment is not an electronic payment")]
        [ExtendedDescription("Cannot reverse a payment that was not made over a payment provider")]
        NotElectronicPayment = 1,

        /// <summary>
        /// Set when the payment has already been fully or partially refunded/reversed.
        /// </summary>
        [Name("Payment already reversed")]
        [ExtendedDescription("Cannot reverse a payment that has already been refunded or reversed")]
        AlreadyReversed = 2,

        /// <summary>
        /// Set when the reference required to perform the reversal is missing.
        /// </summary>
        /// <remarks>
        /// For terminal payments this is the companion and the original RRN; without them we cannot
        /// identify where the payment was accepted and therefore cannot reverse it.
        /// </remarks>
        [Name("Missing payment reversal reference")]
        [ExtendedDescription("Cannot reverse the payment because the original transaction reference is missing")]
        MissingReversalReference = 3,

        /// <summary>
        /// Set when the payment provider does not support reversal through this flow.
        /// </summary>
        [Name("Payment provider not supported")]
        [ExtendedDescription("Cannot reverse the payment because the payment provider is not supported")]
        ProviderNotSupported = 4,
    }
}
