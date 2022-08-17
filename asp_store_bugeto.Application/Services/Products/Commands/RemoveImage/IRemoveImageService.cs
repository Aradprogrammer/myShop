using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.RemoveImage
{
    public interface IRemoveImageService
    {
        public ResultDto Execute(long id);
    }
    public class RemoveImageService : IRemoveImageService
    {
        private readonly IDataBaseContext _context;
        public RemoveImageService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long id)
        {
            var imag = _context.ProductImages.Where(x => x.Id == id).SingleOrDefault();
            if(imag != null)
            {
                imag.IsRemoved = true;
                imag.Removetime = DateTime.Now;
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "" };
            }
            else
            {
                return new() { IsSuccess = false, Message = "تصویر پیدا نشد!" };
            }
        }
    }
}
