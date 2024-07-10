using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Shift error codes.
    /// </summary>
    public enum ShiftExceptionErrorCode
    {
        /// <summary>
        /// No active shift.
        /// </summary>
        [Localized("SHIFT_ERROR_NO_ACTIVE_SHIFT")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_NO_ACTIVE_SHIFT_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_NO_ACTIVE_SHIFT_DESCRIPTION")]
        NoActiveShift = 0,

        /// <summary>
        /// Another shift.
        /// </summary>
        [Localized("SHIFT_ERROR_ANOTHER_ACTIVE")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_ANOTHER_SHIFT_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_ANOTHER_SHIFT_DESCRIPTION")]
        AnotherShift = 1,

        /// <summary>
        /// Already active.
        /// </summary>
        [Localized("SHIFT_ERROR_ALREADY_ACTIVE")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_ALREADY_ACTIVE_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_ALREADY_ACTIVE_DESCRIPTION")]
        AlreadyActive = 2,

        /// <summary>
        /// No register.
        /// </summary>
        [Localized("SHIFT_ERROR_NO_REGISTER")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_NO_REGISTER_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_NO_REGISTER_DESCRIPTION")]
        NoRegister = 3,

        /// <summary>
        /// Invalid shift id.
        /// </summary>
        [Localized("SHIFT_ERROR_INVALID_ID")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_INVALID_SHIFT_ID_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_INVALID_SHIFT_ID_DESCRIPTION")]
        InvalidShiftId = 4,

        /// <summary>
        /// Already ended.
        /// </summary>
        [Localized("SHIFT_ERROR_ALREADY_ENDED")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_ALREADY_ENDED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_ALREADY_ENDED_DESCRIPTION")]
        AlreadyEnded = 5,

        /// <summary>
        /// Shift disabled.
        /// </summary>
        [Localized("SHIFT_ERROR_DISABLED")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_SHIFT_DISABLED_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_SHIFT_DISABLED_DESCRIPTION")]
        ShiftDisabled = 6,

        /// <summary>
        /// No operator.
        /// </summary>
        [Localized("SHIFT_ERROR_NO_OPERATOR")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_NO_OPERATOR_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_NO_OPERATOR_DESCRIPTION")]
        NoOperator = 7,

        /// <summary>
        /// Shift ending.
        /// </summary>
        [Localized("SHIFT_ERROR_ENDING")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_SHIFT_ENDING_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_SHIFT_ENDING_DESCRIPTION")]
        ShiftEnding = 8,

        /// <summary>
        /// Shift not ending.
        /// </summary>
        [Localized("SHIFT_ERROR_NOT_ENDING")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_SHIFT_NOT_ENDING_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_SHIFT_NOT_ENDING_DESCRIPTION")]
        ShiftNotEnding = 9,

        /// <summary>
        /// Deleted register.
        /// </summary>
        [Localized("SHIFT_ERROR_DELETED_REGISTER")]
        [Name("???", "EXCEPTION_ERROR_SHIFT_DELETED_REGISTER_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_SHIFT_DELETED_REGISTER_DESCRIPTION")]
        DeletedRegister = 10,
    }
}
