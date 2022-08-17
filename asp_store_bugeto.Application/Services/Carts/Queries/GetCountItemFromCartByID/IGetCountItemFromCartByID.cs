using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Carts.Queries.GetCountItemFromCartByID
{
    public interface IGetCountItemFromCartByID
    {
        public ResultDto<int?> Execute(long ProductID, Guid BrowserID);
    }
    public class GetCountItemFromCartByID : IGetCountItemFromCartByID
    {
        private IDataBaseContext _context;
        public GetCountItemFromCartByID(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<int?> Execute(long ProductID, Guid BrowserID)
        {
            var cart = _context.Carts.Where(x => x.BrowserId == BrowserID).Include(x => x.CartItems).FirstOrDefault();
            if (cart == null)
                return new() { IsSuccess = false, Message = "سبد خرید وجود ندارد.", Data = null };
            var item = cart.CartItems.Where(x => x.ProductID == ProductID).FirstOrDefault();
            if (item == null)
                return new() { IsSuccess = false, Message = "کالا در سبد خرید وجود ندارد.", Data = null };
            return new() { Data = item.CountItem, IsSuccess = true, Message = "" };

        }
    }
}
