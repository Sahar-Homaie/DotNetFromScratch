

namespace DotNetFromScratch.Generics.Constraints
{
    public class EntityRepository<TEntity>
        where TEntity: IEntity
    {
        private readonly List<TEntity> _entities = new (); 

        public void AddEntity(TEntity newEntity)
        {
            _entities.Add(newEntity);
        }

        public TEntity? Find(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public bool DeleteEntity(int id)
        {
            var entity = Find(id);
            if (entity == null) return false;
            return _entities.Remove(entity);
        }

        public IEnumerable<TEntity> GetAllEntities()
        {
            return _entities;
        }
    }
}
