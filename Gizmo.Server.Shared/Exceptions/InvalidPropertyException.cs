namespace Gizmo.Server.Exceptions
{
    public class InvalidPropertyException : Exception
    {
        private string propertyName;

        public InvalidPropertyException(string propertyName, string message) : base(message)
        {
            this.propertyName = propertyName;
        }

        public string PropertyName
        {
            get
            {
                return propertyName;
            }
        }
    }
}