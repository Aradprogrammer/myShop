using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Common
{
    public static class pagination
    {
        public static IEnumerable<TSource> ToPaged<TSource>(this IEnumerable<TSource> sources, int page, int pageSize, out int rowsCount)
        {
            
            rowsCount = sources.Count();
            return sources.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
