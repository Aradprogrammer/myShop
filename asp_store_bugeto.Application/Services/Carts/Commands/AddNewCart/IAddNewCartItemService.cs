using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Domain.Entities.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Carts.Commands.AddNewCart
{
    public interface IAddNewCartItemService
    {
        public ResultDto Execute(RequestAddCartItem req);
    }

    public class RequestAddCartItem
    {
        public long ProductID { get; set; }
        public int ProductCount { get; set; } = 1;
        public Guid BrowserID { get; set; }
        public long? UserID { get; set; }
    }
    public class AddNewCartItemService : IAddNewCartItemService
    {
        private readonly IDataBaseContext _context;
        public AddNewCartItemService(IDataBaseContext context)
        {
            _context = context;

        }
        public ResultDto Execute(RequestAddCartItem req)
        {
            var product = _context.Products.Where(x => x.Id == req.ProductID).FirstOrDefault();
            if (product == null)
            {
                return new() { IsSuccess = false, Message = "کالا یافت نشد!" };
            }
            Domain.Entities.Carts.Carts cart;
            Domain.Entities.Users.User user = null;
            if (req.UserID != null)
            {
                user = _context.Users.Where(x => x.Id == req.UserID).FirstOrDefault();
                if (user == null)
                    return new() { IsSuccess = false, Message = "کاربر یافت نشد!" };
                cart = _context.Carts.Where(x => x.UserID == req.UserID && x.Finished == false).FirstOrDefault();
            }
            else
            {
                cart = _context.Carts.Where(x => x.BrowserId == req.BrowserID && x.Finished == false).FirstOrDefault();
            }
            if (cart == null)
            {
                var newcart = new Domain.Entities.Carts.Carts()
                {
                    BrowserId = req.BrowserID,
                    Finished = false,
                    InsertTime = DateTime.Now,
                    User = user != null ? user : null,
                };
                _context.Carts.Add(newcart);
                _context.SaveChanges();
                cart = newcart;
            }
            var cartitem = _context.CartItems.Where(x => x.CartID == cart.Id && x.ProductID == product.Id).FirstOrDefault();
            if (cartitem == null)
            {

                if (req.ProductCount > 0)
                {
                    var item = new CartItem()
                    {
                        Cart = cart,
                        CountItem = req.ProductCount,
                        InsertTime = DateTime.Now,
                        Product = product,
                        ProductID = req.ProductID,
                        Price = product.Price
                    };
                    _context.CartItems.Add(item);
                }
                else
                {
                    return new() { IsSuccess = false, Message = "اشکال در مقدار کالا!!" };
                }
            }
            else
            {

                if (req.ProductCount > 0)
                {
                    cartitem.CountItem = req.ProductCount;
                    cartitem.UpDateTime = DateTime.Now;
                    cartitem.Price = product.Price;
                }
                else
                {
                    return new() { IsSuccess = false, Message = "اشکال در مقدار کالا!!" };
                }
            }
            _context.SaveChanges();
            return new() { IsSuccess = true, Message = "عملییات باموفقیت انجام شد." };
        }
    }
}
