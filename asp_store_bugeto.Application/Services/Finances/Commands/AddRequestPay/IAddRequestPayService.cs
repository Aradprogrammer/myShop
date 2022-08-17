using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Domain.Entities.Finances;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Finances.Commands.AddRequestPay
{
    public interface IAddRequestPayService
    {
        public ResultDto<RequestPayDto> Execute(RequestForAddRequestpeyDto req);
    }

    public class RequestPayDto
    {
        public Guid PayGuid { get; set; }
        public int Amount { get; set; }
        public string UserEmail { get; set; }
        public long RequestPayId { get; set; }

    }

    public class RequestForAddRequestpeyDto
    {
        public long UserID { get; set; }
        public Guid BrowserId { get; set; }
        public long CartID { get; set; }

    }
    public class AddRequestPayService : IAddRequestPayService
    {
        private readonly IDataBaseContext _context;
        public AddRequestPayService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RequestPayDto> Execute(RequestForAddRequestpeyDto req)
        {
            var cart = _context.Carts.Where(x => x.UserID == req.UserID && x.BrowserId == req.BrowserId).Include(x => x.CartItems).ThenInclude(x => x.Product).FirstOrDefault();
            if (cart == null || cart.CartItems.Count < 1)
                return new() { IsSuccess = false, Message = "سبد خریدی یافت نشد!!" };
            var user = _context.Users.Find(req.UserID);
            if (user == null)
                return new() { IsSuccess = false, Message = "کاربر یافت نشد!!" };
            int Amount = cart.CartItems.Sum(x => x.CountItem * x.Product.Price);
            var requestpay = new RequestPay()
            {
                InsertTime = DateTime.Now,
                User = user,
                isPay = false,
                Guid = Guid.NewGuid(),
                Amount = Amount
            };
            _context.RequestPays.Add(requestpay);
            _context.SaveChanges();
            return new() { IsSuccess = true, Message = "", Data = new() { PayGuid = requestpay.Guid, Amount = requestpay.Amount, UserEmail = user.Email, RequestPayId = requestpay.Id } };

        }
    }

}
