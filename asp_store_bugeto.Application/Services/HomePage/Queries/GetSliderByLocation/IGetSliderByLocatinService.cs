using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Queries.GetSliderByLocation
{
    public interface IGetSliderByLocatinService
    {
        public ResultDto<List<ProductForSliderDto>> Execut(string Location);
    }

    public class ProductForSliderDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
    public class GetSliderByLocationService : IGetSliderByLocatinService
    {
        private IDataBaseContext _context;
        public GetSliderByLocationService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ProductForSliderDto>> Execut(string Location)
        {
            int row;
            var slider = _context.SlidersCategory.Where(p => p.CategorySliderLocation == Location).FirstOrDefault();
            if (slider != null && slider.CategoryId != null)
            {
                var item = _context.Products.Include(p => p.ProductImages).Where(p => p.CategoryID == slider.CategoryId).OrderByDescending(p => p.Id).ToPaged(1, slider.CountItem, out row).Select(p => new ProductForSliderDto() { Id = p.Id, Name = p.Name, Price = p.Price, Image = p.ProductImages.First().Src }).ToList();
                return new() { Data = item, IsSuccess = true, Message = "" };
            }
            return new ResultDto<List<ProductForSliderDto>>() { IsSuccess = false, Message = "اسلایدر پیدا نشد!" };
        }
    }
}
