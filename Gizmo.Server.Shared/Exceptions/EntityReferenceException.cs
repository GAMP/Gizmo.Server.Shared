namespace Gizmo.Server.Exceptions
{
    public class EntityReferenceException : EntityException
    {
        public EntityReferenceException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType) : base(entityKey, entityType)
        {
            ReferenceEntityKey = referenceEntityKey;
            ReferenceEntityType = referenceEntityType ?? throw new ArgumentNullException(nameof(referenceEntityType));
        }

        public EntityReferenceException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType, string message) : base(entityKey, entityType, message)
        {
            ReferenceEntityKey = referenceEntityKey;
            ReferenceEntityType = referenceEntityType ?? throw new ArgumentNullException(nameof(referenceEntityType));
        }

        #region PROPERTIES

        /// <summary>
        /// Gets reference entity id.
        /// </summary>
        public int? ReferenceEntityKey
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets reference entity type.
        /// </summary>
        public Type ReferenceEntityType
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets reference entity keys.
        /// </summary>
        public object[] ReferenceKeys
        {
            get; set;
        }

        #endregion
    }

    public class EntityReferenceException<TEntityType, TReferenceEntityType> : EntityReferenceException
    {
        public EntityReferenceException(int entityKey,int referenceEntityKey):base(entityKey,typeof(TEntityType), referenceEntityKey, typeof(TReferenceEntityType))
        {

        }
    }
}