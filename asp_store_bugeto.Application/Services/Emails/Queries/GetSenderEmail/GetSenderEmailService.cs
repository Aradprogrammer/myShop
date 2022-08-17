using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Common;
using System.Collections.Generic;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail
{
    public class GetSenderEmailService : IGetSenderEmailService
    {
        private IDataBaseContext _context;
        public GetSenderEmailService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<SendersEmailDto> Execute(RequestSenderDto request)
        {
            var senders = _context.SenderEmails.AsQueryable();
            var result = new List<SenderDto>();
            int countrow = 0;
            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                result =
                    senders
                    .Where(p => p.AddressEmail.Contains(request.SearchKey))
                    .ToPaged(request.Page, request.PageSize, out countrow)
                    .Select(p => new SenderDto()
                    {
                        Id = p.Id,
                        Addres = p.AddressEmail,
                        Password = p.Password
                    })
                    .ToList();
            }
            else
            {
                result =
                    senders
                    .ToPaged(request.Page, request.PageSize, out countrow)
                    .Select(p => new SenderDto()
                    {
                        Id = p.Id,
                        Addres = p.AddressEmail,
                        Password = p.Password
                    })
                    .ToList();
            }
            return new() { Message = "عملیات با موفقیت انحام شد.", IsSuccess = true, Data = new() { CountRow = countrow, Senders = result } };
        }
    }
}
