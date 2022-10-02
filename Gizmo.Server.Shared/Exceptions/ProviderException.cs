using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Provider exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Provider)]
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
