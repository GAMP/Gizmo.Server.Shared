namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity exception base.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    public abstract class EntityKeyExceptionBase<TEntityType> : EntityTypeExceptionBase<TEntityType>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        public EntityKeyExceptionBase(int entityKey):base()
        {            
            EntityKey = entityKey;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="message">Exception message.</param>
        public EntityKeyExceptionBase(int entityKey,string message):base(message)
        {
            EntityKey = entityKey;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="keys">Entity keys.</param>
        public EntityKeyExceptionBase(object[] keys):base()
        {
            EntityKeys = keys;
        } 

        #endregion

        #region PROPERTIES

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