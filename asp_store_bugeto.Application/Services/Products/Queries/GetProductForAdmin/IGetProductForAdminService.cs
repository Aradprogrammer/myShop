using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin
{
    public interface IGetProductForAdminService
    {
        public ResultDto<ProductDto> Execute(long Id);
    }

    public class ProductDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public bool Displayed { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public string Description { get; set; }
        public List<ImagesProduct> Images { get; set; }
        public List<FeatursProduct> Featurs { get; set; }
    }

    public class ImagesProduct
    {
        public long ID { get; set; }
        public string Src { get; set; }

    }

    public class FeatursProduct
    {
        public long ID { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

    }
    public class GetProductForAdminService : IGetProductForAdminService
    {
        private readonly IDataBaseContext _context;
        private IMapper _mapper;
        public GetProductForAdminService(IDataBaseContext context ,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ResultDto<ProductDto> Execute(long Id)
        {
            try
            {
                var product = _context.Products
                    .Where(x => x.Id == Id)
                    .Include(x => x.ProductFeature)
                    .Include(x => x.ProductImages)
                    .Include(x => x.Category)
                    .ThenInclude(x => x.ParentCategory)
                    .Include(x => x.Category).FirstOrDefault();
                var result = _mapper.Map<ProductDto>(product);
                return new() { Data = result, IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new() { IsSuccess = false, Message = ex.Message };
            }
        }
    }

}
