using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Order status error codes.
    /// </summary>
    public enum OrderStatusExceptionErrorCode
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [Name("Order status unspecified error", "EXCEPTION_ERROR_ORDER_STATUS_UNSPECIFIED_NAME")]
        [ExtendedDescription("Unspecified error while performing the action", "EXCEPTION_ERROR_ORDER_STATUS_UNSPECIFIED_DESCRIPTION")]
        Unspecified = 0,

        /// <summary>
        /// Already completed.
        /// </summary>
        [Name("Order already completed", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_COMPLETED_NAME")]
        [ExtendedDescription("Cannot perform the action because order is already completed", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_COMPLETED_DESCRIPTION")]
        AlreadyCompleted = 1,

        /// <summary>
        /// Already canceled.
        /// </summary>
        [Name("Order already canceled", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_CANCELED_NAME")]
        [ExtendedDescription("Cannot perform the action because order is already canceled", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_CANCELED_DESCRIPTION")]
        AlreadyCanceled = 2,

        /// <summary>
        /// Already accepted.
        /// </summary>
        [Name("Order already accepted", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_ACCEPTED_NAME")]
        [ExtendedDescription("Cannot perform the action because order is already accepted", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_ACCEPTED_DESCRIPTION")]
        AlreadyAccepted = 3,

        /// <summary>
        /// Already invoiced.
        /// </summary>
        [Name("Order already invoiced", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_INVOICED_NAME")]
        [ExtendedDescription("Cannot perform the action because order is already invoiced", "EXCEPTION_ERROR_ORDER_STATUS_ALREADY_INVOICED_DESCRIPTION")]
        AlreadyInvoiced = 4,

        /// <summary>
        /// Not accepted.
        /// </summary>
        [Name("Order not accepted", "EXCEPTION_ERROR_ORDER_STATUS_NOT_ACCEPTED_NAME")]
        [ExtendedDescription("Cannot perform the action because order is not accepted", "EXCEPTION_ERROR_ORDER_STATUS_NOT_ACCEPTED_DESCRIPTION")]
        NotAccepted = 5,
    }
}
