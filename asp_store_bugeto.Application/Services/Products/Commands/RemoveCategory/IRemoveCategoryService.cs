using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.RemoveCategory
{
    public interface IRemoveCategoryService
    {
        public ResultDto Execute(long Id);
    }
    public class RemoveCategoryService : IRemoveCategoryService
    {
        private readonly IDataBaseContext _context;
        public RemoveCategoryService(IDataBaseContext context)
        {
            _context = context;

        }

        public ResultDto Execute(long Id)
        {
            var category = _context.Categories.Find(Id);
            if (category == null)
            {
                return new() { IsSuccess = false, Message = "دسته بندی پیدا نشد!" };
            }
            else
            {
                category.IsRemoved = true;
                category.Removetime = DateTime.Now;
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
            }

        }
    }
}
