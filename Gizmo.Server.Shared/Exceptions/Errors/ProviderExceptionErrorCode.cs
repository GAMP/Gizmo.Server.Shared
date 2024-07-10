using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment provider error codes.
    /// </summary>
    public enum ProviderExceptionErrorCode
    {
        /// <summary>
        /// Provider not found.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_PROVIDER_NOT_FOUND_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_PROVIDER_NOT_FOUND_DESCRIPTION")]
        NotFound = 0,

        /// <summary>
        /// Provider does not have an option type associated with it.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_PROVIDER_NO_OPTIONS_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_PROVIDER_NO_OPTIONS_DESCRIPTION")]
        NoOptions = 1,

        /// <summary>
        /// The type provided is invalid or cant be loaded.
        /// </summary>
        [Name("???", "EXCEPTION_ERROR_PROVIDER_INVALID_TYPE_NAME")]
        [ExtendedDescription("???", "EXCEPTION_ERROR_PROVIDER_INVALID_TYPE_DESCRIPTION")]
        InvalidType =2,
    }
}
