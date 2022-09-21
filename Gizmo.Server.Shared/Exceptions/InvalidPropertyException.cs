namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Invalid property excpeption.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.InvalidProperty)]
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