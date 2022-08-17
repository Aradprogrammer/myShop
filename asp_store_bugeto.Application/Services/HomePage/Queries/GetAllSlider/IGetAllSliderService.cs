using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Queries.GetAllSlider
{
    public interface IGetAllSliderService
    {
        public ResultDto<List<SliderDto>> Execute();
    }

    public class SliderDto
    {
        public string Location { get; set; }
        public string CatName { get; set; }
        public long Id { get; set; }
        public long CatID { get; set; }
    }
    public class GetAllSliderService : IGetAllSliderService
    {
        private IDataBaseContext _context;
        public GetAllSliderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<SliderDto>> Execute()
        {
            var sliders = _context.SlidersCategory.Include(p => p.Category).Select(p => new SliderDto() { CatID = p.CategoryId ?? 0, CatName = p.Category.Name ?? "", Id = p.Id, Location = p.CategorySliderLocation }).ToList();

            return new() { Data = sliders, IsSuccess = true, Message = "" };
        
        }
    }
}
