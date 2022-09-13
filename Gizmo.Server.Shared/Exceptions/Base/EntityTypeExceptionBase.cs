namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity type exception base.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    public class EntityTypeExceptionBase<TEntityType> : Exception
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public EntityTypeExceptionBase(string message) : base(message)
        {
            EntityType = typeof(TEntityType);
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public EntityTypeExceptionBase()
        {
            EntityType = typeof(TEntityType);
        }

        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets entity type.
        /// </summary>
        public Type EntityType
        {
            get; protected set;
        }
        #endregion
    }
}
