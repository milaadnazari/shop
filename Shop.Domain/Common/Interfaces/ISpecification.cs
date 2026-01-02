using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Common.Interfaces
{
    public interface ISpecification<T>
    {
        // شرط اصلی Where
        Expression<Func<T, bool>> Criteria { get; }

        // Includeهای مرتبط (Eager Loading)
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }

        // مرتب‌سازی
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

        // صفحه‌بندی
        bool IsPagingEnabled { get; }
        int Take { get; }
        int Skip { get; }

        // گروه‌بندی (Group By)
        Expression<Func<T, object>> GroupBy { get; }
    }
}
