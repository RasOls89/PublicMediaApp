using System.Linq.Expressions;
using DataLayer.Internals;

namespace DataLayer
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly PublicMediaContext  _context;
        public Repository(PublicMediaContext dbContext) => _context = dbContext;

        public void Add(TEntity entity) => _context.Add(entity);


        public void AddRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().AddRange(entities);


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().ToList();

        public TEntity GetById(object id) => _context.Set<TEntity>().Find(id);


        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}