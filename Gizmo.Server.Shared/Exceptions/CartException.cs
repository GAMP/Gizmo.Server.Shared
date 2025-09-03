using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Cart exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Cart)]
    public sealed class CartException : ErrorCodeExceptionBase<CartErrorCode>
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public CartException(CartErrorCode errorCode) : base(errorCode)
        {
        }
    }
}
