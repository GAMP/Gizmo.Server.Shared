using Gizmo.Shared.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Payment provider exception.
    /// </summary>
    [ExceptionFilterCode(Web.Api.WebApiErrorCode.PaymentProvider)]
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
