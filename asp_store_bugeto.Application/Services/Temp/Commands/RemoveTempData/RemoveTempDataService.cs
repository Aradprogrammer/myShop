using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Temp.Commands.RemoveTempData
{
    public class RemoveTempDataService : IRemoveTempDataService
    {
        private readonly IDataBaseContext _context;
        public RemoveTempDataService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(string key)
        {
            var data = _context.Temps.Where(p => p.Key == key).FirstOrDefault();
            if (data != null)
            {
                data.IsRemoved = true;
                data.Removetime = DateTime.Now;
                _context.SaveChanges();
                return new ResultDto() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
            }
            else
            {
                return new() { IsSuccess = false, Message = "فیلدی با این کلید وجود ندارد." };
            }
        }
    }
}
