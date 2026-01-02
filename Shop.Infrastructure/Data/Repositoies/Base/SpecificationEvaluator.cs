using Microsoft.EntityFrameworkCore;
using Shop.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Repositoies.Base
{
    public class SpecificationEvaluator<T> where T : class
    {
        public static IQueryable<T> GetQuery(
            IQueryable<T> inputQuery,
            ISpecification<T> specification)
        {
            var query = inputQuery;

            // اعمال Where
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // اعمال Includes با عبارت Lambda
            query = specification.Includes
                .Aggregate(query, (current, include) => current.Include(include));

            // اعمال Includes با رشته
            query = specification.IncludeStrings
                .Aggregate(query, (current, include) => current.Include(include));

            // اعمال مرتب‌سازی
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            // اعمال Group By
            if (specification.GroupBy != null)
            {
                query = query.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            // اعمال صفحه‌بندی
            if (specification.IsPagingEnabled)
            {
                query = query.Skip(specification.Skip)
                             .Take(specification.Take);
            }

            return query;
        }
    }
}
