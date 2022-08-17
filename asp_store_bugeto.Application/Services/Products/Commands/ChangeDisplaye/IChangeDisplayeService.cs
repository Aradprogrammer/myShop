using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.ChangeDisplaye
{
    public interface IChangeDisplayeService
    {
        public ResultDto Execute(long Id);
    }
    public class ChangeDisplayeService : IChangeDisplayeService
    {
        private readonly IDataBaseContext _context;
        public ChangeDisplayeService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long Id)
        {
            var product = _context.Products.Where(x => x.Id == Id).SingleOrDefault();
            if (product == null)
            {
                return new() { IsSuccess = false, Message = "محصول یافت نشد!" };
            }
            else
            {
                product.Displayed = !product.Displayed;

                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "" };
            }
        }
    }
}
