using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Carts.Commands.RemoveCartItem
{
    public interface IRemoveCartItem
    {
        public ResultDto Execute(Guid BrowserID, long ProductId, long cartId);
    }
    public class RemoveCartItem : IRemoveCartItem
    {

        private readonly IDataBaseContext _context;
        public RemoveCartItem(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(Guid BrowserID, long ProductId, long cartId)
        {

            var cart = _context.Carts.Where(x => (x.Id == cartId || x.BrowserId == BrowserID) && x.Finished == false).FirstOrDefault();
            if (cart == null)
            {
                return new() { IsSuccess = false, Message = "سبد خرید یافت نشد!" };
            }
            var item = _context.CartItems.Where(x => x.CartID == cart.Id && x.ProductID == ProductId).FirstOrDefault();
            if(item == null)
            {
                return new() { IsSuccess = false, Message = "محصول یافت نشد!" };
            }
            item.Removetime = DateTime.Now;
            item.IsRemoved = true;
            _context.SaveChanges();
            return new() { IsSuccess = true, Message = "محصول از سبد خرید حذف شد." };
        }
    }

}
