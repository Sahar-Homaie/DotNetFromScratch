

namespace DotNetFromScratch.Generics.GenericInterfaces
{
    public interface IInMemoryRepository<TEntity,TId>: IRepository<TEntity,TId>
        where TEntity: IEntity<TId>
    {
        void Clear();
    }
}
