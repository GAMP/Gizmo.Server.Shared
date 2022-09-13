namespace Gizmo.Server.Exceptions
{
    public class EntityNotReferencedException : EntityReferenceException
    {
        public EntityNotReferencedException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType) : base(entityKey, entityType, referenceEntityKey, referenceEntityType) { }

        public EntityNotReferencedException(int entityKey, Type entityType, int referenceEntityKey, Type referenceEntityType, string message) : base(entityKey, entityType, referenceEntityKey, referenceEntityType, message) { }
    }

    public class EntityNotReferencedException<TEntityType,TReferenceEntityType> : EntityNotReferencedException
    {
        public EntityNotReferencedException(int entityKey,int referenceKey):base(entityKey,typeof(TEntityType),referenceKey,typeof(TReferenceEntityType))
        {

        }
    }


}