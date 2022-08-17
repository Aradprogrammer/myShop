using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.EditCategory
{
    public interface IEditCategoryService
    {
        public ResultDto Execute(long Id, string Name);
    }
    public class EditCategoryService : IEditCategoryService
    {
        private readonly IDataBaseContext _context;
        public EditCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id, string Name)
        {
            var category = _context.Categories.Find(Id);
            if (category == null)
            {
                return new()
                {
                    IsSuccess = false,
                    Message = "دسته بندی پیدا نشد!"
                };
            }
            if (!string.IsNullOrEmpty(Name))
            {
                category.Name = Name;
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
            }
            else
            {
                return new() { IsSuccess = false, Message = "لطفا نام دسته بندی را وارد کنید." };
            }
        }
    }
}
