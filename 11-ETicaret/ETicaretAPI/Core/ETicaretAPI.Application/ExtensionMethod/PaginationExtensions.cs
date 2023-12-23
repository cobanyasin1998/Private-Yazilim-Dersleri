using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.ExtensionMethod
{
    public static class PaginationExtensions
    {
        public static IQueryable<T> Paginate<T, TKey>(
        this IQueryable<T> query,
        int page = 0,
        int pageSize = 5,
        Expression<Func<T, TKey>> orderBy = null,
        bool descending = true) where T : BaseEntity
        {

            query = descending ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);


            return query
                .Skip(page * pageSize)
                .Take(pageSize);
        }
    }
}
