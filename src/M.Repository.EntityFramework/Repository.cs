using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace M.Repository.EntityFramework
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbContext context;
        private readonly IDbSet<TEntity> set;

        public Repository(DbContext context)
        {
            this.context = context;
            set = context.Set<TEntity>();
        }

        public TEntity Find<TKey>(EntityId<TEntity, TKey> id)
        {
            return set.Find(id.Id);
        }

        public async Task<TEntity> FindAsync<TKey>(EntityId<TEntity, TKey> id)
        {
            return await context.Set<TEntity>().FindAsync(id.Id);
        }

        public void Add(TEntity entity)
        {
            set.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if(!set.Local.Contains(entity))
            {
                set.Attach(entity);
            }

            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (!set.Local.Contains(entity))
            {
                set.Attach(entity);
            }

            context.Set<TEntity>().Remove(entity);
        }

        public TResult GetBy<TResult>(IQuery<TEntity, TResult> query)
        {
            IQueryable<TEntity> queryable = ApplyQuerySettings(query);

            return query.ExecuteAgainst(queryable);
        }

        public async Task<TResult> GetByAsync<TResult>(IQueryAsync<TEntity, TResult> query)
        {
            IQueryable<TEntity> queryable = ApplyQuerySettings(query);

            return await query.ExecuteAgainstAsync(queryable);
        }

        private IQueryable<TEntity> ApplyQuerySettings<TResult>(IQueryBase<TEntity, TResult> query)
        {
            IQueryable<TEntity> queryable = context.Set<TEntity>();
            if (query.ReadOnly)
            {
                queryable = queryable.AsNoTracking();
            }

            foreach (var include in query.Includes)
            {
                queryable = queryable.Include(include);
            }

            return queryable;
        }
    }
}
