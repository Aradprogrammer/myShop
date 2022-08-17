namespace asp_store_bugeto.Application.Services.Products.Queries.GetProducts
{
    public class ProductDtoForList
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string CategoryName { get; set; }
        public string FirstImg { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public int StarsCount { get; set; }
    }
}
