namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity exception base.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    public abstract class EntityExceptionBase<TEntityType> : Exception
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        public EntityExceptionBase(int entityKey)
        {
            EntityType = typeof(TEntityType);
            EntityKey = entityKey;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="message">Exception message.</param>
        public EntityExceptionBase(int entityKey,string message):base(message)
        {
            EntityType = typeof(TEntityType);
            EntityKey = entityKey;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="keys">Entity keys.</param>
        public EntityExceptionBase(object[] keys)
        {
            EntityType = typeof(TEntityType);
            EntityKeys = keys;
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

        /// <summary>
        /// Gets entity key.
        /// </summary>
        public int? EntityKey
        {
            get;
        }

        /// <summary>
        /// Gets entity keys.
        /// </summary>
        public object[]? EntityKeys
        {
            get;
        } 

        #endregion
    }
}