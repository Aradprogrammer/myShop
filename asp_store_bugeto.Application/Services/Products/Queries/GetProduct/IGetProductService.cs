using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetProduct
{
    public interface IGetProductService
    {
        public ResultDto<ProductDateilsDto> Execute(long ID);
    }

    public class ProductDateilsDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public List<string> ImagesSrc { get; set; }
        public List<FeaturDto> Featurs { get; set; }
        public string Description { get; set; }

    }

    public class FeaturDto
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class GetProductService : IGetProductService
    {
        private readonly IDataBaseContext _context;
        public GetProductService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ProductDateilsDto> Execute(long ID)
        {
            var product = _context.Products.Include(x => x.ProductImages).Include(x => x.Category).ThenInclude(x => x.ParentCategory).Include(x => x.ProductFeature).Where(x => x.Id == ID).SingleOrDefault();
            if (product != null)
            {
                var result = new ProductDateilsDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Brand = product.Brand,
                    Description = product.Description,
                    Inventory = product.Inventory,
                    Price = product.Price,
                    Category = $"{product.Category.ParentCategory.Name} - {product.Category.Name}",
                    ImagesSrc = product.ProductImages.Select(x => x.Src).ToList(),
                    Featurs = product.ProductFeature.Select(x => new FeaturDto() { Name = x.Name, Value = x.Value }).ToList()
                };
                product.VisitCount++;
                _context.SaveChanges();
                return new() { Data = result, IsSuccess = true, Message = "" };
            }
            else
            {
                return new() { IsSuccess = false, Message = "کالا پیدا نشد !" };
            }
        }
    }
}
