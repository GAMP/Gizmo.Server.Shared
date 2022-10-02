using Gizmo.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Host reservation exception.
    /// </summary>
    [Serializable]
    [ExceptionFilterCode(ExceptionCode.HostReservation)]
    public class HostReservationException : ErrorCodeExceptionBase<ReservationExceptionErrorCode>
    {
        #region CONSTRUCTOR
     
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Reservation error code.</param>
        public HostReservationException(ReservationExceptionErrorCode errorCode) : base(errorCode)
        { }

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Serialization context.</param>
        protected HostReservationException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        { }

        #endregion
    }
}
