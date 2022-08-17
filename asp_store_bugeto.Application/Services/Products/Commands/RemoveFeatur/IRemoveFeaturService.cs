using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Products.Commands.RemoveFeatur
{
    public interface IRemoveFeaturService
    {
        public ResultDto Execute(long Id);
    }

    public class RemoveFeaturService : IRemoveFeaturService
    {
        private readonly IDataBaseContext _context;
        public RemoveFeaturService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long Id)
        {
            var featur=_context.ProductFeatures.Where(x=>x.Id==Id).SingleOrDefault();
            if (featur != null)
            {
                featur.IsRemoved = true;
                featur.Removetime = DateTime.Now;
                _context.SaveChanges();
                return new() { IsSuccess = true, Message = "" };
            }
            else
            {
                return new() { IsSuccess = false, Message = "ویژگی یافت نشد!" };
            }
        }
    }
}
