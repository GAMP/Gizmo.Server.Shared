using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Shift exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Shift)]
    public class ShiftException : ErrorCodeExceptionBase<ShiftExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public ShiftException(ShiftExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected ShiftException(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
