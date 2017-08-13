using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M.Repository.EntityFramework
{
    /// <summary>
    /// Represents an asynchronous query operations.
    /// </summary>
    /// <seealso cref="M.Repository.IQueryableAsyncExtensionsProxy" />
    public class EfQueryableAsyncExtensions : IQueryableAsyncExtensionsProxy
    {
        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if every element of the source sequence passes the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.AllAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if every element of the source sequence passes the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AllAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to check for being empty.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the source sequence contains any elements; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to check for being empty.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the source sequence contains any elements; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if any elements in the source sequence pass the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if any elements in the source sequence pass the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AnyAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<int> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<int> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<int?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<long> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<long> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<long?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> AverageAsync(IQueryable<float> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> AverageAsync(IQueryable<float> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> AverageAsync(IQueryable<float?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> AverageAsync(IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<double> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync(IQueryable<double> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<double?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync(IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> AverageAsync(IQueryable<decimal> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> AverageAsync(IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> AverageAsync(IQueryable<decimal?> source)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> AverageAsync(IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="item">The object to locate in the sequence.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the input sequence contains the specified value; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item)
        {
            return System.Data.Entity.QueryableExtensions.ContainsAsync(source, item);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="item">The object to locate in the sequence.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the input sequence contains the specified value; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ContainsAsync(source, item, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> CountAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.CountAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" /> that passes the test in
        /// <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" /> that passes the test in
        /// <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if
        /// <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if
        /// <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition
        /// or a default value if no such element is found.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if <paramref name="source" />
        /// is empty or if no element passes the test specified by <paramref name="predicate" /> ; otherwise, the first
        /// element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition
        /// or a default value if no such element is found.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if <paramref name="source" />
        /// is empty or if no element passes the test specified by <paramref name="predicate" /> ; otherwise, the first
        /// element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.FirstOrDefaultAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the number of elements in a sequence
        /// that satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the number of elements in a sequence
        /// that satisfy a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.LongCountAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" /> .</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" /> .</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MaxAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> MinAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> MinAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" /> .</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" /> .</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.MinAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception
        /// if there is not exactly one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception
        /// if there is not exactly one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty;
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence, or <c>default</c> (<typeparamref name="TSource" />)
        /// if the sequence contains no elements.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty;
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence, or <c>default</c> (<typeparamref name="TSource" />)
        /// if the sequence contains no elements.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if more than one element
        /// satisfies the condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />, or <c>default</c> ( <typeparamref name="TSource" /> ) if no such element is found.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if more than one element
        /// satisfies the condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />, or <c>default</c> ( <typeparamref name="TSource" /> ) if no such element is found.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SingleOrDefaultAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains  the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> SumAsync(IQueryable<int> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> SumAsync(IQueryable<int> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int32" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int?> SumAsync(IQueryable<int?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int32" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int?> SumAsync(IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> SumAsync(IQueryable<long> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> SumAsync(IQueryable<long> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int64" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long?> SumAsync(IQueryable<long?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int64" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long?> SumAsync(IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> SumAsync(IQueryable<float> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> SumAsync(IQueryable<float> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Single" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> SumAsync(IQueryable<float?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Single" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> SumAsync(IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> SumAsync(IQueryable<double> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> SumAsync(IQueryable<double> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Double" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> SumAsync(IQueryable<double?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Double" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> SumAsync(IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> SumAsync(IQueryable<decimal> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> SumAsync(IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the sum of.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> SumAsync(IQueryable<decimal?> source)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the sum of.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> SumAsync(IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" /> .</typeparam>
        /// <param name="source">A sequence of values of type <typeparamref name="TSource" /> .</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Creates an array from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to create an array from.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains an array that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.ToArrayAsync(source);
        }

        /// <summary>
        /// Creates an array from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to create an array from.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains an array that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToArrayAsync(source, cancellationToken);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable" /> by enumerating it asynchronously.
        /// </summary>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<List<object>> ToListAsync(IQueryable source)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable" /> by enumerating it asynchronously.
        /// </summary>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<List<object>> ToListAsync(IQueryable source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source, cancellationToken);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <see cref="T:System.Linq.IQueryable`1" /> to create a list from.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return System.Data.Entity.QueryableExtensions.ToListAsync(source, cancellationToken);
        }
    }
}
