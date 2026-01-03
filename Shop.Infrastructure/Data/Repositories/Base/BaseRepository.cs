using Shop.Application.Common.Interfaces;
using Shop.Domain.Common.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Repositories.Base
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<int> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Detach(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
