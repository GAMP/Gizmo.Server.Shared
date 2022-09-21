namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity not referenced exception.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    /// <typeparam name="TReferenceEntityType">Reference entity type.</typeparam>
    [ExceptionFilterCode(ExceptionCode.EntityNotReferenced)]
    public class EntityNotReferencedException<TEntityType,TReferenceEntityType> : EntityReferenceExceptionBase<TEntityType,TReferenceEntityType>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="referenceKey">Reference entity key.</param>
        public EntityNotReferencedException(int entityKey, int referenceKey) : base(entityKey, referenceKey)
        {
        }
        #endregion

        #region OVERRIDES
        public override string Message => $"Specified entity {EntityType} with id {EntityKey} is not referenced by entity {ReferenceEntityType} with id {ReferenceEntityKey}."; 
        #endregion
    }
}