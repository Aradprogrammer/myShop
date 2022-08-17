using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetProducts
{
    public class ResultGetProductDto
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public List<ProductDtoForList> Products { get; set; }
    }
}
