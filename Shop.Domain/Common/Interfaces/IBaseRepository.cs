using Shop.Domain.Common.Bases;
using Shop.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Common.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        // ========== متدهای خواندن (Queries) ==========

        // تک آیتم
        Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<T?> GetBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);

        // لیست
        Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<T>> ListBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);

        // کمکی
        Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(int id, CancellationToken cancellationToken = default);

        // ========== متدهای تغییر تک آیتم ==========
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default); // اضافه کردن Overload

        // ========== متدهای دسته‌جمعی (Bulk Operations) ==========

        // اضافه کردن دسته‌جمعی
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        // به‌روزرسانی دسته‌جمعی
        Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        // حذف دسته‌جمعی
        Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
        Task DeleteRangeAsync(IEnumerable<int> ids, CancellationToken cancellationToken = default);
        Task DeleteBySpecAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);

        // ========== متدهای پیشرفته ==========

        // Unit of Work
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        // دنبال کردن یا قطع دنبال کردن
        void Attach(T entity);
        void Detach(T entity);
    }
}
