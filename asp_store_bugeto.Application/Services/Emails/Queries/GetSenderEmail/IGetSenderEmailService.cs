using asp_store_bugeto.Common.Dto;
using System;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail
{
    public interface IGetSenderEmailService
    {
        public ResultDto<SendersEmailDto> Execute(RequestSenderDto request);
    }
}
