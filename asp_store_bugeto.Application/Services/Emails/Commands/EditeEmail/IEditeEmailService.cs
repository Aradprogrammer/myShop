using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Commands.EditeEmail
{
    public interface IEditeEmailService
    {
        public ResultDto Execute(RequestEditeEmail req);
    }

    public class RequestEditeEmail
    {
        public long EmailId { get; set; }
        public string EmailText { get; set; }
        public string EmailTitel { get; set; }
        public long SenderId { get; set; }
    }
    public class RequestEditeValidator : AbstractValidator<RequestEditeEmail>
    {
        public RequestEditeValidator()
        {
            RuleFor(x => x.EmailId).NotEmpty().WithMessage("ایمیل پیدا نشد لطفا صفحه را مجددا بازگذاری کنید.");
            RuleFor(x => x.EmailText).NotEmpty().WithMessage("لطفا متن ایمیل را وارد کنید.");
            RuleFor(x => x.EmailTitel).NotEmpty().WithMessage("لطفا عنوان ایمیل را وارد کنید.");
            RuleFor(x => x.SenderId).NotEmpty().WithMessage("لطفا ارسال کننده را وارد کنید.");
        }
    }
    public class EditeEmailService : IEditeEmailService
    {
        private readonly IDataBaseContext _context;
        public EditeEmailService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditeEmail req)
        {
            var email = _context.Emails.Find(req.EmailId);
            if (email == null)
            {
                return new() { IsSuccess = false, Message = "ایمیل پیدا نشد!" };
            }
            else
            {
                var vadidation = new RequestEditeValidator();
                var result = vadidation.Validate(req);
                if (result.IsValid)
                {
                    email.Text = req.EmailText;
                    email.Titel = req.EmailTitel;
                    email.SenderEmailId = req.SenderId;
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "عملیات ویرایش با موفقیت انحام شد." };
                }
                else
                {
                    return new() { IsSuccess = false, Message = result.Errors[0].ErrorMessage.ToString() };
                }
            }
        }
    }
}
