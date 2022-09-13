using Gizmo.Server.Web.Api;
using Gizmo.Shared.Exceptions;
using System.Runtime.Serialization;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Host reservation exception.
    /// </summary>
    [Serializable]
    [DataContract()]
    [ExceptionFilterCode(WebApiErrorCode.HostReservation)]
    public class HostReservationException : ErrorCodeExceptionBase<ReservationErrorCode>
    {
        #region CONSTRUCTOR
     
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="errorCode">Reservation error code.</param>
        public HostReservationException(ReservationErrorCode errorCode) : base(errorCode)
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
