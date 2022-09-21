namespace Gizmo.Server.Exceptions
{
    /// <summary>
    /// Entity in use exception.
    /// </summary>
    [ExceptionFilterCode(ExceptionCode.EntityInUse)]
    public class EntityInUseException<TEntityType> : EntityKeyExceptionBase<TEntityType>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        public EntityInUseException(int entityKey) : base(entityKey)
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="entityKey">Entity key.</param>
        /// <param name="message">Exception message.</param>
        public EntityInUseException(int entityKey,string message) : base(entityKey,message)
        {
        }

        #endregion

        #region OVERRIDES
        public override string Message => $"Specified entity {EntityType} with id {EntityKey} is in use."; 
        #endregion
    }
}