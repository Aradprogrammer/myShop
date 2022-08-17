using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Common;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetEmails
{
    public class GetEmailsService : IGetEmailsService
    {
        private readonly IDataBaseContext _context;
        public GetEmailsService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultEmailDto> Execute(RequestEmailDto requestEmailDto)
        {
            var email = _context.Emails.AsQueryable();
            int rowCount = 0;
            var result = new List<EmailsDto>();
            if (!string.IsNullOrEmpty(requestEmailDto.SearchKey))
            {
                result = email.Include(p => p.SenderEmail)
                    .Where(p => p.Subject.Contains(requestEmailDto.SearchKey))
                    .ToPaged(requestEmailDto.Page, 10, out rowCount)
                    .Select(p =>
                    new EmailsDto()
                    {
                        Id = p.Id,
                        SenderEmailId = p.SenderEmail.Id,
                        SenderEmailAddress = p.SenderEmail.AddressEmail,
                        Subject = p.Subject,
                        Text = p.Text,
                        Titel = p.Titel,
                    }).ToList();
            }
            else
            {
                result = email.Include(p => p.SenderEmail)
                    .ToPaged(requestEmailDto.Page, 10, out rowCount)
                    .Select(p =>
                    new EmailsDto()
                    {
                        Id = p.Id,
                        SenderEmailAddress = p.SenderEmail.AddressEmail,
                        SenderEmailId = p.SenderEmail.Id,
                        Subject = p.Subject,
                        Text = p.Text,
                        Titel = p.Titel,
                    }).ToList();
            }
            return new()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد.",
                Data = new()
                {
                    DataList = result,
                    RowCount = rowCount
                }
            };
        }
    }
}
