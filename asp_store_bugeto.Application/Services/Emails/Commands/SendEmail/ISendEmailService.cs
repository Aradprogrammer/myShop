using asp_store_bugeto.Common.Dto;

namespace asp_store_bugeto.Application.Services.Emails.Commands.SendEmail
{
    public interface ISendEmailService
    {
        public ResultDto Execute(string Email, string subject, string host, string content = "");

    }
}
