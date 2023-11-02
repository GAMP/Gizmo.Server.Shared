using System.Net;
using Gizmo.Exceptions;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Custom exception used to communicate http errors to the exception filter.
    /// </summary>
    /// <remarks>
    /// This will be used in order for us to be able to produce wrapped response for an exception raised in one of the services api controllers might use.<br></br>
    /// The only current use is unnauthorized access.
    /// </remarks>
    [ExceptionFilterCode(ExceptionCode.HttpResponseException)]
    public sealed class HttpResponseException : ErrorCodeExceptionBase<HttpStatusCode>
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="httpStatusCode">Http status code.</param>
        public HttpResponseException(HttpStatusCode httpStatusCode):base(httpStatusCode) 
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="httpStatusCode">Http status code.</param>
        /// <param name="message">Message.</param>
        public HttpResponseException(HttpStatusCode httpStatusCode, string message) : base(message, httpStatusCode)
        {
        }
    }
}
