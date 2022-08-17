using asp_store_bugeto.Common.Dto;
using System;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Queries.GetEmails
{
    public interface IGetEmailsService
    {
        public ResultDto<ResultEmailDto> Execute(RequestEmailDto requestEmailDto);
    }
}
