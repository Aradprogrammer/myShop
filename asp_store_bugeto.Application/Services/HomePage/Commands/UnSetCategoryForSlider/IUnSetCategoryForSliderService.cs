using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Commands.UnSetCategoryForSlider
{
    public interface IUnSetCategoryForSliderService
    {
        public ResultDto Execute(long Id);
    }
    public class UnSetCategoryForSliderService : IUnSetCategoryForSliderService
    {
        private IDataBaseContext _context;
        public UnSetCategoryForSliderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long Id)
        {
            if (Id > 0)
            {
                var slider = _context.SlidersCategory.Find(Id);
                if (slider != null)
                {
                    slider.UpDateTime = DateTime.Now;
                    slider.Category = null;
                    slider.CategoryId = null;
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات باموفقیت انجام شد." };
                }
                else
                {
                    return new() { IsSuccess = false, Message = "اسلایدر پیدا نشد!" };
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = "شماره اسلایدر را وارد کنید!" };
            }
        }
    }
}
