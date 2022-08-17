using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.HomePage.Commands.RemovePicHome
{
    public interface IRemovePicHomeService
    {
        public ResultDto Execute(long Id);
    }
    public class RemovePicHomeService : IRemovePicHomeService
    {
        private IDataBaseContext _context;
        public RemovePicHomeService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long Id)
        {
            if (Id != null && Id > 0)
            {
                var Pic = _context.PicsAndLinks.Find(Id);
                if (Pic != null)
                {
                    Pic.IsRemoved = true;
                    Pic.Removetime = DateTime.Now;
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات باموفقیت انجام شد." };
                }
                else
                {
                    return new() { IsSuccess = false, Message = "تصویر یافت نشد!" };
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = "تصویر یافت نشد!" };
            }
        }
    }
}
