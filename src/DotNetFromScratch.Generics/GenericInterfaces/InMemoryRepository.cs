

namespace DotNetFromScratch.Generics.GenericInterfaces
{
    public class InMemoryRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity: IEntity<TId> 
    {
        private readonly List<TEntity> _entities = new();
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public TEntity? Find(TId id)
        {
            return _entities.FirstOrDefault(en => EqualityComparer<TId>.Default.Equals(en.Id ,id));
        }
        public bool Delete(TId id)
        {
            var selectedEntity = Find(id);
            if (selectedEntity == null) return false;
            return _entities.Remove(selectedEntity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities;
        }
    }
}
