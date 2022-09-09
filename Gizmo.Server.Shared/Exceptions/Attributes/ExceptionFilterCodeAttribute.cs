using Gizmo.Server.Exceptions.Errors;
using Gizmo.Shared.Exceptions;
using System;
using System.Runtime.Serialization;
using Gizmo.Server.Web.Api;

namespace Gizmo.Server.Exceptions.Attributes
{
    /// <summary>
    /// Asset exception.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class ExceptionFilterCodeAttribute : Attribute
    {
        public WebApiErrorCode ErrorCode { get; set; }

        public ExceptionFilterCodeAttribute(WebApiErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
