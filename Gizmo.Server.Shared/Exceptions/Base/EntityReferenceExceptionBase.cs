namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity reference exception base.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    /// <typeparam name="TReferenceEntityType">Entity reference type.</typeparam>
    public abstract class EntityReferenceExceptionBase<TEntityType, TReferenceEntityType> : EntityExceptionBase<TEntityType> 
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="referenceEntityKey">Reference entity key.</param>
        public EntityReferenceExceptionBase(int entityKey, int referenceEntityKey) : base(entityKey)
        {
            ReferenceEntityKey = referenceEntityKey;
            ReferenceEntityType = typeof(TReferenceEntityType);
        } 

        #endregion

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
        public object[]? ReferenceKeys
        {
            get; set;
        }

        #endregion
    }
}