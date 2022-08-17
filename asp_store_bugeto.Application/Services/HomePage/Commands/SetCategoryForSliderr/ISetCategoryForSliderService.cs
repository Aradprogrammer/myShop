using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Commands.SetCategoryForSliderr
{
    public interface ISetCategoryForSliderService
    {
        public ResultDto Execute(RequestSetCategoryForSlider req);
    }

    public class RequestSetCategoryForSlider
    {
        public long CategoryId { get; set; }
        public int CountItem { get; set; }
        public string Location { get; set; }
    }
    public class SetCategoryForSliderService : ISetCategoryForSliderService
    {
        private IDataBaseContext _context;
        public SetCategoryForSliderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestSetCategoryForSlider req)
        {
            var Slider = _context.SlidersCategory.Where(p => p.CategorySliderLocation.Equals(req.Location)).FirstOrDefault();
            if (Slider != null)
            {
                if (Slider.CategoryId == null)
                {
                    Slider.Category = _context.Categories.Find(req.CategoryId);
                    Slider.CategoryId = req.CategoryId;
                    Slider.CountItem = req.CountItem;
                    Slider.UpDateTime = DateTime.Now;
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
                }
                else
                {
                    return new() { Message = "برای این اسلایدر دسته بندی تایین شده است!", IsSuccess = false };
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = "اسلایدر پیدا نشد!" };
            }
        }
    }
}
