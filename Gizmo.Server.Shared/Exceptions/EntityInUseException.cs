namespace Gizmo.Server.Exceptions
{
    public class EntityInUseException : EntityException
    {
        public EntityInUseException(int entityKey, Type entityType) : base(entityKey, entityType) { }

        public EntityInUseException(int entityKey, Type entityType, string message) : base(entityKey, entityType, message) { }
    }

    public class EntityInUseException<TEntityType>:EntityInUseException
    {
        public EntityInUseException(int entityKey):base(entityKey,typeof(TEntityType))
        {
        }
    }
}