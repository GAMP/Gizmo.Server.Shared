using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Promotion exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.Promotion)]
    public sealed class PromotionException : ErrorCodeExceptionBase<PromotionErrorCode>
    {
        public PromotionException(PromotionErrorCode code) : base(code) { }
    }
}
