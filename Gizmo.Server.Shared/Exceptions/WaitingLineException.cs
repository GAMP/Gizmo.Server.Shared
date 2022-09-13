using Gizmo.Server.Exceptions.Attributes;
using Gizmo.Server.Exceptions.Errors;
using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Waiting line exception.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ExceptionFilterCode(WebApiErrorCode.WaitingLine)]
    public class WaitingLineException : ErrorCodeExceptionBase<WaitingLineErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="code">Error code.</param>
        public WaitingLineException(WaitingLineErrorCode code) : base(code)
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineException() : base() { }


        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public WaitingLineException(string message)
          : base(message)
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public WaitingLineException(string message, Exception inner)
            : base(message, inner)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected WaitingLineException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
