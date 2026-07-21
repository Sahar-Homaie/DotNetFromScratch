

namespace DotNetFromScratch.Generics.GenericInterfaces
{
    public interface IRepository<TEntity, TId>
        where TEntity: IEntity<TId>
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity? Find(TId id);
        bool Delete(TId id);

    }
}
