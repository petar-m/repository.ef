using System.Data.Entity;
using System.Threading.Tasks;

namespace M.Repository.EntityFramework
{
    /// <summary>
    /// Represents a logic to track and persist entity changes.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;

        /// <summary>
        /// Creates a new instance of UnitOfWork class.
        /// </summary>
        /// <param name="context">The DbContext instance representing unit of work.</param>
        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Persists all changes as a single transaction.
        /// </summary>
        public void Commit()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Persists all changes as a single transaction asynchronously.
        /// </summary>
        /// <returns>A task representing the persistence result.</returns>
        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Discards all changes.
        /// </summary>
        public void Rollback()
        {
            context.Dispose();
        }
    }
}
