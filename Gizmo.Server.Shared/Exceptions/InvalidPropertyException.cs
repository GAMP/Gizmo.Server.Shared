using System.ComponentModel.DataAnnotations;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Invalid property exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.InvalidProperty)]
    [Name("Invalid property error", "EXCEPTION_TYPE_INVALID_PROPERTY_NAME")]
    [ExtendedDescription("Invalid property related error", "EXCEPTION_TYPE_INVALID_PROPERTY_DESCRIPTION")]
    public class InvalidPropertyException : Exception
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        /// <param name="message">Exception message.</param>
        public InvalidPropertyException(string propertyName, string message) : base(message)
        {
            _propertyName = propertyName;
        } 
        #endregion

        #region FIELDS
        private readonly string _propertyName;
        #endregion

        #region PROPERTIES
        
        /// <summary>
        /// Gets property name.
        /// </summary>
        public string PropertyName
        {
            get
            {
                return _propertyName;
            }
        } 

        #endregion       
    }
}
