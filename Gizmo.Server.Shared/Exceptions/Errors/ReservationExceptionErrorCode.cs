using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Reservation error codes.
    /// </summary>
    public enum ReservationExceptionErrorCode
    {
        /// <summary>
        /// Entry already added to reservation.
        /// </summary>
        [Name("Reservation entry already added", "EXCEPTION_ERROR_RESERVATION_ALREADY_ADDED_NAME")]
        [ExtendedDescription("Cannot perform the action because the host or the user is already added", "EXCEPTION_ERROR_RESERVATION_ALREADY_ADDED_DESCRIPTION")]
        AlreadyAdded = 0,

        /// <summary>
        /// Entry not present.
        /// </summary>
        [Name("Reservation entry not present", "EXCEPTION_ERROR_RESERVATION_NOT_PRESENT_NAME")]
        [ExtendedDescription("Cannot perform the action because the host or the user is not present", "EXCEPTION_ERROR_RESERVATION_NOT_PRESENT_DESCRIPTION")]
        NotPresent = 1,

        /// <summary>
        /// Reservation is inactive.
        /// </summary>
        [Name("Reservation is inactive", "EXCEPTION_ERROR_RESERVATION_RESERVATION_INACTIVE_NAME")]
        [ExtendedDescription("Cannot perform the action because the reservation is inactive", "EXCEPTION_ERROR_RESERVATION_RESERVATION_INACTIVE_DESCRIPTION")]
        ReservationInactive = 2,

        /// <summary>
        /// Invalid reservation date.
        /// </summary>
        [Name("Invalid reservation date", "EXCEPTION_ERROR_RESERVATION_INVALID_DATE_NAME")]
        [ExtendedDescription("Cannot perform the action because the reservation has invalid date", "EXCEPTION_ERROR_RESERVATION_INVALID_DATE_DESCRIPTION")]
        InvalidDate = 3,

        /// <summary>
        /// Invalid reservation duration.
        /// </summary>
        [Name("Invalid reservation duration", "EXCEPTION_ERROR_RESERVATION_INVALID_DURATION_NAME")]
        [ExtendedDescription("Cannot perform the action because the reservation has invalid duration", "EXCEPTION_ERROR_RESERVATION_INVALID_DURATION_DESCRIPTION")]
        InvalidDuration = 4,

        /// <summary>
        /// Reservation overlaps.
        /// </summary>
        [Name("Reservation overlaps", "EXCEPTION_ERROR_RESERVATION_OVERLAP_NAME")]
        [ExtendedDescription("Cannot perform the action because the reservation overlaps another reservation", "EXCEPTION_ERROR_RESERVATION_OVERLAP_DESCRIPTION")]
        Overlap = 5,
    }
}
