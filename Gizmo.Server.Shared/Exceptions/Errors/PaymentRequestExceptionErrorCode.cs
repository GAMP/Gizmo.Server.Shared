using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment request creation error codes.
    /// </summary>
    public enum PaymentRequestExceptionErrorCode
    {
        /// <summary>
        /// Internal error.
        /// </summary>
        [Name("Payment requeset unspecified error", "EXCEPTION_ERROR_PAYMENT_REQUEST_ERROR_NAME")]
        [ExtendedDescription("Unspecified error while executing payment request", "EXCEPTION_ERROR_PAYMENT_REQUEST_ERROR_DESCRIPTION")]
        Error = 0,

        /// <summary>
        /// Provider error.
        /// </summary>
        [Name("Payment requeset provider error", "EXCEPTION_ERROR_PAYMENT_REQUEST_PROVIDER_ERROR_NAME")]
        [ExtendedDescription("Cannot create payment request due to provider error", "EXCEPTION_ERROR_PAYMENT_REQUEST_PROVIDER_ERROR_DESCRIPTION")]
        ProviderError = 1,

        /// <summary>
        /// No payment provider.
        /// </summary>
        [Name("Payment provider not found", "EXCEPTION_ERROR_PAYMENT_REQUEST_PAYMENT_PROVIDER_NOT_FOUND_NAME")]
        [ExtendedDescription("Cannot create payment request because the payment provider not found", "EXCEPTION_ERROR_PAYMENT_REQUEST_PAYMENT_PROVIDER_NOT_FOUND_DESCRIPTION")]
        PaymentProviderNotFound = 2,

        /// <summary>
        /// No payment provider, for example if payment method don't have one associated with it.
        /// </summary>
        [Name("Payment request no payment provider", "EXCEPTION_ERROR_PAYMENT_REQUEST_NO_PAYMENT_PROVIDER_NAME")]
        [ExtendedDescription("Cannot create payment request because the specified payment method does not have an associated payment provider", "EXCEPTION_ERROR_PAYMENT_REQUEST_NO_PAYMENT_PROVIDER_DESCRIPTION")]
        NoPaymentProvider = 3,

        /// <summary>
        /// External host is required for cancel and success url.
        /// </summary>
        [Name("External host is required", "EXCEPTION_ERROR_PAYMENT_REQUEST_EXTERNAL_HOST_REQUIRED_NAME")]
        [ExtendedDescription("The external host is required", "EXCEPTION_ERROR_PAYMENT_REQUEST_EXTERNAL_HOST_REQUIRED_DESCRIPTION")]
        ExternalHostRequired = 4,

        /// <summary>
        /// External host is not valid.
        /// </summary>
        [Name("Invalid external host", "EXCEPTION_ERROR_PAYMENT_REQUEST_INVALID_EXTERNAL_HOST_NAME")]
        [ExtendedDescription("The specified external host is invalid", "EXCEPTION_ERROR_PAYMENT_REQUEST_INVALID_EXTERNAL_HOST_DESCRIPTION")]
        InvalidExternalHost = 5,
    }
}
