using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace M.Repository.EntityFramework
{
    /// <summary>
    /// A repository for managing entities utilizing EntityFramework.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities managed.</typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbContext context;
        private readonly IDbSet<TEntity> set;

        /// <summary>
        /// Creates a new instance of the Repository class.
        /// </summary>
        /// <param name="context">The DbContext instance the repository uses.</param>
        public Repository(DbContext context)
        {
            this.context = context;
            set = context.Set<TEntity>();
        }

        /// <summary>
        /// Finds an entity by its identifier.
        /// </summary>
        /// <typeparam name="TKey">The type of the entity identifier.</typeparam>
        /// <param name="id">The concrete entity identifier.</param>
        /// <returns>The entity identified by the given id or null if not found.</returns>
        public TEntity Find<TKey>(EntityId<TEntity, TKey> id)
        {
            return set.Find(id.Id);
        }

        /// <summary>
        /// Finds an entity by its identifier asynchronously.
        /// </summary>
        /// <typeparam name="TKey">The type of the entity identifier.</typeparam>
        /// <param name="id">The concrete entity identifier.</param>
        /// <returns>The entity identified by the given id or null if not found.</returns>
        public async Task<TEntity> FindAsync<TKey>(EntityId<TEntity, TKey> id)
        {
            return await context.Set<TEntity>().FindAsync(id.Id);
        }

        /// <summary>
        /// Adds an entity to the repository.
        /// </summary>
        /// <param name="entity">An entity to add to the repository.</param>
        public void Add(TEntity entity)
        {
            set.Add(entity);
        }

        /// <summary>
        /// Updates an entity existing in the repository.
        /// </summary>
        /// <param name="entity">An entity to update.</param>
        public void Update(TEntity entity)
        {
            if (!set.Local.Contains(entity))
            {
                set.Attach(entity);
            }

            context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes an entity eixisting in the repository.
        /// </summary>
        /// <param name="entity">An entity to delete from the repository.</param>
        public void Delete(TEntity entity)
        {
            if (!set.Local.Contains(entity))
            {
                set.Attach(entity);
            }

            context.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Searches the repository for entities.
        /// </summary>
        /// <typeparam name="TResult">The type of the search result.</typeparam>
        /// <param name="query">A query instance representing the entity filter.</param>
        /// <returns>The search result.</returns>
        public TResult GetBy<TResult>(IQuery<TEntity, TResult> query)
        {
            IQueryable<TEntity> queryable = ApplyQuerySettings(query);

            return query.ExecuteAgainst(queryable);
        }

        /// <summary>
        /// Searches the repository for entities asynchronously.
        /// </summary>
        /// <typeparam name="TResult">The type of the search result.</typeparam>
        /// <param name="query">A query instance representing the entity filter.</param>
        /// <returns>A task representing the search result.</returns>
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
