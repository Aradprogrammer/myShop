using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.RemoveProduct
{
    public interface IRemoveProductService
    {
        public ResultDto Execute(long id);
    }
    public class RemoveProductService : IRemoveProductService
    {
        private readonly IDataBaseContext _context;
        public RemoveProductService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long id)
        {
            var product = _context.Products.Where(x => x.Id == id).Include(x=>x.ProductFeature).Include(x=>x.ProductImages).SingleOrDefault();
            if(product != null)
            {
                product.IsRemoved = true;
                product.Removetime = DateTime.Now;
                foreach(var image in product.ProductImages)
                {
                    image.IsRemoved = true;
                    image.Removetime = DateTime.Now;
                }
                foreach(var featur in product.ProductFeature)
                {
                    featur.IsRemoved = true;
                    featur.Removetime = DateTime.Now;
                }
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "" };
            }
            else
            {
                return new() { IsSuccess = false, Message = "محصول پیدا نشد!" };
            }
        }
    }
}
