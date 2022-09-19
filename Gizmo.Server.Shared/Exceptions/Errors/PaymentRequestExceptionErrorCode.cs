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
        Error = 0,
        /// <summary>
        /// Provider error.
        /// </summary>
        ProviderError = 1,
        /// <summary>
        /// No payment provider.
        /// </summary>
        PaymentProviderNotFound = 2,
        /// <summary>
        /// No paymen provider, for example if payment method dont have one associated with it.
        /// </summary>
        NoPaymentProvider = 3,
        /// <summary>
        /// External host is required for cancel and success url.
        /// </summary>
        ExternalHostRequired = 4,
        /// <summary>
        /// External host is not valid.
        /// </summary>
        InvalidExternalHost=5,
    }
}
