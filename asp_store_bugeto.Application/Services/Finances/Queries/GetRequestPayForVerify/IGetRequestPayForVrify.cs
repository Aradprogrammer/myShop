using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Finances.Queries.GetRequestPayForVerify
{
    public interface IGetRequestPayForVrify
    {
        public ResultDto<RequestPayDto> Execute(Guid guidPay);
    }

    public class RequestPayDto
    {
        public int Amount { get; set; }
    }
    public class GetRequestPayForVerify : IGetRequestPayForVrify
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayForVerify(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<RequestPayDto> Execute(Guid guidPay)
        {
            var result = _context.RequestPays.Where(x => x.Guid == guidPay).FirstOrDefault();
            if (result != null)
                return new() { IsSuccess = true, Message = "", Data = new() { Amount = result.Amount } };
            else
                return new() { IsSuccess = false, Message = "شماره پرداخت پیدا نشد!!!" };
        }
    }
}
