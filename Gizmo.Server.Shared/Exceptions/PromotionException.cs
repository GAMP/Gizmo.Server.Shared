using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Promotion exception.
    /// </summary>
    public sealed class PromotionException : ErrorCodeExceptionBase<PromotionErrorCode>
    {
        public PromotionException(PromotionErrorCode code) : base(code) { }
    }
}
