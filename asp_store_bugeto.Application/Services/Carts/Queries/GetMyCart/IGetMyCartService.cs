using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Carts.Queries.GetMyCart
{
    public interface IGetMyCartService
    {
        public ResultDto<NyCartDto> Execute(Guid BrowserId, long? UserId);
    }

    public class NyCartDto
    {
        public long CartId { get; set; }
        public long? UserId { get; set; }
        public Guid BrowserId { get; set; }
        public int CountItem { get; set; }
        public List<CartItemDto> Items { get; set; }
        public int TotalPrice { get; set; }


    }

    public class CartItemDto
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImgSrc { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public int CountItem { get; set; }
    }
    public class GetMyCartService : IGetMyCartService
    {
        private readonly IDataBaseContext _Context;
        public GetMyCartService(IDataBaseContext context)
        {
            _Context = context;
        }

        public ResultDto<NyCartDto> Execute(Guid BrowserId, long? UserId)
        {
            var cart = _Context.Carts.Where(x => (x.BrowserId == BrowserId || x.UserID == UserId) && x.Finished == false).Include(x => x.CartItems).ThenInclude(x => x.Product).ThenInclude(x => x.ProductImages).FirstOrDefault();

            if (cart == null)
                return new() { IsSuccess = false, Message = "سبد خرید یافت نشد!!" };
            if (UserId != null)
            {
                cart.UserID = UserId;
                _Context.SaveChanges();
            }
            var items = cart.CartItems.Select(x => new CartItemDto() { CountItem = x.CountItem, Price = x.Product.Price, ProductId = x.ProductID, ProductName = x.Product.Name, ImgSrc = x.Product.ProductImages.FirstOrDefault().Src, Total = x.CountItem * x.Product.Price }).ToList();
            if (items == null)
                return new() { IsSuccess = false, Message = "سبد خرید خالی است!" };
            int total = items.Sum(x => x.CountItem * x.Price);
            int countitems = cart.CartItems.Count();
            return new() { IsSuccess = true, Message = "", Data = new() { BrowserId = BrowserId, CartId = cart.Id, Items = items, TotalPrice = total, UserId = UserId, CountItem = countitems } };
        }
    }
}
