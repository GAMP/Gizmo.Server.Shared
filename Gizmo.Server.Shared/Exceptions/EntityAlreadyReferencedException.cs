namespace Gizmo.Server.Exceptions
{
    public class EntityAlreadyReferencedException : EntityReferenceException
    {
        public EntityAlreadyReferencedException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType) : base(entityKey, entityType, referenceEntityKey, referenceEntityType) { }

        public EntityAlreadyReferencedException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType, string message) : base(entityKey, entityType, referenceEntityKey, referenceEntityType, message) { }
    }

    public class EntityAlreadyReferencedException<TEntityType, TEntityReferenceType> : EntityReferenceException
    {
        public EntityAlreadyReferencedException(int entityKey, int referenceEntityKey) : base(entityKey, typeof(TEntityType), referenceEntityKey, typeof(TEntityReferenceType))
        {

        }
    }
}