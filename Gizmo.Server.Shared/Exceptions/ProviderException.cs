using System.ComponentModel.DataAnnotations;
using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Provider exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Provider)]
    [Name("Provider error", "EXCEPTION_TYPE_PROVIDER_NAME")]
    [ExtendedDescription("Provider related error", "EXCEPTION_TYPE_PROVIDER_DESCRIPTION")]
    public sealed class ProviderException : ErrorCodeExceptionBase<ProviderExceptionErrorCode>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public ProviderException(ProviderExceptionErrorCode errorCode) : base(errorCode)
        { }
        #endregion
    }
}
