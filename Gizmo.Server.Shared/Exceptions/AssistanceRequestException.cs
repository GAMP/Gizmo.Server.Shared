using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.AssistanceRequest)]
    [Name("Assistance request error", "EXCEPTION_TYPE_ASSISTANCE_REQUEST_NAME")]
    [ExtendedDescription("Assistance request related error", "EXCEPTION_TYPE_ASSISTANCE_REQUEST_DESCRIPTION")]
    public class AssistanceRequestException : ErrorCodeExceptionBase<AssistanceRequestErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public AssistanceRequestException(AssistanceRequestErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected AssistanceRequestException(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
