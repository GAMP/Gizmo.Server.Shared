using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Billing profile exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.BillingProfile)]
    public class BillingProfileException : ErrorCodeExceptionBase<BillingProfileExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public BillingProfileException(BillingProfileExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected BillingProfileException(SerializationInfo info,
           StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
