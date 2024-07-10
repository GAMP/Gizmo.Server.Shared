using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Billing profile error codes.
    /// </summary>
    public enum BillingProfileExceptionErrorCode
    {
        /// <summary>
        /// Set when we try to create a rate step to an invalid minute.
        /// </summary>
        [Name("Billing profile invalid minute", "EXCEPTION_ERROR_BILLING_PROFILE_INVALID_MINUTE_NAME")]
        [ExtendedDescription("Cannot create rate step due to invalid minute", "EXCEPTION_ERROR_BILLING_PROFILE_INVALID_MINUTE_DESCRIPTION")]
        InvalidMinute = 0,

        /// <summary>
        /// Set when we try to create a rate with multiple loop steps.
        /// </summary>
        [Name("Billing profile multiple loops", "EXCEPTION_ERROR_BILLING_PROFILE_MULTIPLE_LOOPS_NAME")]
        [ExtendedDescription("Cannot create rate step due to multiple loops", "EXCEPTION_ERROR_BILLING_PROFILE_MULTIPLE_LOOPS_DESCRIPTION")]
        MultipleLoops = 1,
    }
}
