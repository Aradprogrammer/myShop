namespace asp_store_bugeto.Application.Services.Products.Queries.GetProducts
{
    public class RequestGetProduct
    {
        public int Page { get; set; } = 1;
        public string Search { get; set; } = "";
        public int PageSize { get; set; } = 20;
        public long? CategoryId { get; set; }
        public Ordering Orderby { get; set; }

    }
}
