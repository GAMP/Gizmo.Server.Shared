namespace Gizmo.Server.Exceptions
{
    public class EntityException : Exception
    {
        public EntityException(int entityKey, Type entityType)
        {
            EntityKey = entityKey;
            EntityType = entityType ?? throw new ArgumentNullException(nameof(entityType));
        }

        public EntityException(int entityKey, Type entityType, string message) : base(message)
        {
            EntityKey = entityKey;
            EntityType = entityType ?? throw new ArgumentNullException(nameof(entityType));
        }

        #region PROPERTIES

        /// <summary>
        /// Gets entity id.
        /// </summary>
        public int? EntityKey
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets entity type.
        /// </summary>
        public Type EntityType
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets entity keys.
        /// </summary>
        public object[] EntityKeys
        {
            get; set;
        }

        #endregion
    }

    public class EntityException<TEntityType> : EntityException
    {
        public EntityException(int entityKey):base(entityKey, typeof(TEntityType))
        {
        }

        public Type Type
        {
            get;protected set;
        }
    }
}