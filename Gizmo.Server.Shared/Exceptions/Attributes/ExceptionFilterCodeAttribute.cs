using Gizmo.Server.Web.Api;

namespace Gizmo.Server.Exceptions.Attributes
{
    /// <summary>
    /// Asset exception.
    /// </summary>
    public class ExceptionFilterCodeAttribute : Attribute
    {
        public WebApiErrorCode ErrorCode { get; set; }

        public ExceptionFilterCodeAttribute(WebApiErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
