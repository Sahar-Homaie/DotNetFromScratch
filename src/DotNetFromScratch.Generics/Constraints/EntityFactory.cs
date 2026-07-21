


namespace DotNetFromScratch.Generics.Constraints
{
    public class EntityFactory<TEntity>
        where TEntity:  class , IEntity, new()
    {
        public TEntity CreateRefTypeEntity()
        {
            return new TEntity();
        }
    }
}
