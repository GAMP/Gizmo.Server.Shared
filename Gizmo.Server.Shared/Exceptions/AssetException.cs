using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Asset exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Asset)]
    public class AssetException : ErrorCodeExceptionBase<AssetExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public AssetException(AssetExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected AssetException(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
