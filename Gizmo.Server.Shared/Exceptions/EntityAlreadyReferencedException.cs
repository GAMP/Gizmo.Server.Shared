using Gizmo.Server.Web.Api;

namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity already referenced exception.
    /// </summary>
    /// <typeparam name="TEntityType">Entity type.</typeparam>
    /// <typeparam name="TEntityReferenceType">Reference entity type.</typeparam>
    [ExceptionFilterCode(WebApiErrorCode.EntityAlreadyReferenced)]
    public class EntityAlreadyReferencedException<TEntityType, TEntityReferenceType> : EntityReferenceExceptionBase<TEntityType, TEntityReferenceType>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="referenceEntityKey">Reference entity key.</param>
        public EntityAlreadyReferencedException(int entityKey, int referenceEntityKey) : base(entityKey, referenceEntityKey)
        {
        }
        #endregion

        #region OVERRIDES
        public override string Message => $"Specified entity {EntityType} with id {EntityKey} is already referenced by entity {ReferenceEntityType} with id {ReferenceEntityKey}."; 
        #endregion
    }
}