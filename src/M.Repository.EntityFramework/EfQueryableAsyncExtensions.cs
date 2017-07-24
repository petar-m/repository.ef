using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M.Repository.EntityFramework
{
    public class EfQueryableAsyncExtensions : IQueryableAsyncExtensionsProxy
    {
        public Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.AllAsync(source, predicate);
        }

        public Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AllAsync(source, predicate, cancellationToken);
        }

        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source);
        }

        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, cancellationToken);
        }

        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, predicate);
        }

        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, predicate, cancellationToken);
        }

        public Task<double> AverageAsync(IQueryable<int> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double> AverageAsync(IQueryable<int> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double?> AverageAsync(IQueryable<int?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double?> AverageAsync(IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double> AverageAsync(IQueryable<long> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double> AverageAsync(IQueryable<long> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double?> AverageAsync(IQueryable<long?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double?> AverageAsync(IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<float> AverageAsync(IQueryable<float> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<float> AverageAsync(IQueryable<float> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<float?> AverageAsync(IQueryable<float?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<float?> AverageAsync(IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double> AverageAsync(IQueryable<double> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double> AverageAsync(IQueryable<double> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double?> AverageAsync(IQueryable<double?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<double?> AverageAsync(IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<decimal> AverageAsync(IQueryable<decimal> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<decimal> AverageAsync(IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<decimal?> AverageAsync(IQueryable<decimal?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        public Task<decimal?> AverageAsync(IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        public Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        public Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item)
        {
            return System.Data.Entity.QueryableExtensions.ContainsAsync(source, item);
        }

        public Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ContainsAsync(source, item, cancellationToken);
        }

        public Task<int> CountAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source);
        }

        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source);
        }

        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source, predicate);
        }

        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source, predicate, cancellationToken);
        }

        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source);
        }

        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, cancellationToken);
        }

        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, predicate);
        }

        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, predicate, cancellationToken);
        }

        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source);
        }

        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, cancellationToken);
        }

        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, predicate);
        }

        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, predicate, cancellationToken);
        }

        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source);
        }

        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, cancellationToken);
        }

        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, predicate);
        }

        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, predicate, cancellationToken);
        }

        public Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source);
        }

        public Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, cancellationToken);
        }

        public Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, selector);
        }

        public Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, selector, cancellationToken);
        }

        public Task<TSource> MinAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source);
        }

        public Task<TSource> MinAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, cancellationToken);
        }

        public Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, selector);
        }

        public Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, selector, cancellationToken);
        }

        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source);
        }

        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, cancellationToken);
        }

        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, predicate);
        }

        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, predicate, cancellationToken);
        }

        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source);
        }

        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, cancellationToken);
        }

        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, predicate);
        }

        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, predicate, cancellationToken);
        }

        public Task<int> SumAsync(IQueryable<int> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<int> SumAsync(IQueryable<int> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<int?> SumAsync(IQueryable<int?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<int?> SumAsync(IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<long> SumAsync(IQueryable<long> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<long> SumAsync(IQueryable<long> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<long?> SumAsync(IQueryable<long?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<long?> SumAsync(IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<float> SumAsync(IQueryable<float> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<float> SumAsync(IQueryable<float> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<float?> SumAsync(IQueryable<float?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<float?> SumAsync(IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<double> SumAsync(IQueryable<double> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<double> SumAsync(IQueryable<double> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<double?> SumAsync(IQueryable<double?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<double?> SumAsync(IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<decimal> SumAsync(IQueryable<decimal> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<decimal> SumAsync(IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<decimal?> SumAsync(IQueryable<decimal?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        public Task<decimal?> SumAsync(IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        public Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        public Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        public Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.ToArrayAsync(source);
        }

        public Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToArrayAsync(source, cancellationToken);
        }

        public Task<List<object>> ToListAsync(IQueryable source)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source);
        }

        public Task<List<object>> ToListAsync(IQueryable source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source, cancellationToken);
        }

        public Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source);
        }

        public Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source, cancellationToken);
        }
    }
}
