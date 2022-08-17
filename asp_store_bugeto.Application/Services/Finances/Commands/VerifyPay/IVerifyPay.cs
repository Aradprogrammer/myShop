using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Finances.Commands.VerifyPay
{
    public interface IVerifyPay
    {
        public ResultDto<verifyResultDto> Execute(RequestVerifyPay req);
    }

    public class verifyResultDto
    {
    }

    public class RequestVerifyPay
    {
        public Guid GuidPay { get; set; }
        public string Authority { get; set; }
        public int RefId { get; set; }

    }
    public class VerifyPay : IVerifyPay
    {
        private readonly IDataBaseContext _context;
        public VerifyPay(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<verifyResultDto> Execute(RequestVerifyPay req)
        {
            var pay = _context.RequestPays.Where(x => x.Guid == req.GuidPay).FirstOrDefault();
            if (pay == null)
                return new() { IsSuccess = false, Message = "پرداخت پیدا نشد!!!" };
            pay.Authority = req.Authority;
            pay.RefId = req.RefId;
            pay.isPay = true;
            pay.PayDate = DateTime.Now;
            long userid = pay.UserID;
            _context.SaveChanges();
            var cart = _context.Carts.Where(x => x.UserID == userid && x.Finished == false).FirstOrDefault();
            cart.Finished = true;
            cart.UpDateTime = DateTime.Now;
            _context.SaveChanges();
            return new() { IsSuccess = true, Message = "", };
        }
    }
}
