namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity in use exception.
    /// </summary>
    public class EntityInUseException : EntityException
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="entityType"></param>
        public EntityInUseException(int entityKey, Type entityType) : base(entityKey, entityType) { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="entityType">Entity type.</param>
        /// <param name="message">Message.</param>
        public EntityInUseException(int entityKey, Type entityType, string message) : base(entityKey, entityType, message) { } 
        #endregion
    }

    /// <summary>
    /// Entity in use exception.
    /// </summary>
    public class EntityInUseException<TEntityType> : EntityInUseException
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        public EntityInUseException(int entityKey) : base(entityKey, typeof(TEntityType))
        {
        } 
        #endregion
    }
}