using Gizmo.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Deposit exception.
    /// </summary>
    [Serializable()]
    [ExceptionFilterCode(ExceptionCode.Deposit)]
    [Name("Deposit error", "EXCEPTION_TYPE_DEPOSIT_NAME")]
    [ExtendedDescription("Deposit related error", "EXCEPTION_TYPE_DEPOSIT_DESCRIPTION")]
    public class DepositException : ErrorCodeExceptionBase<DepositExceptionErrorCode>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public DepositException(DepositExceptionErrorCode errorCode) : base(errorCode)
        {
        }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected DepositException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
