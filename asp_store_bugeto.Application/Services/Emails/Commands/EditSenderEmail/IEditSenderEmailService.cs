using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Commands.EditSenderEmail
{
    public interface IEditSenderEmailService
    {
        public ResultDto Execute(RequestEditSenderEmailDto req);
    }

    public class RequestEditSenderEmailDto
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class EditSenderEmailService : IEditSenderEmailService
    {
        readonly private IDataBaseContext _context;
        public EditSenderEmailService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditSenderEmailDto req)
        {
            var validation = new RequestEditSenderEmailDtoValidation();
            var valid = validation.Validate(req);
            if (valid.IsValid)
            {
                var sender = _context.SenderEmails.Find(req.Id);
                if (sender != null)
                {
                    if (!sender.IsRemoved)
                    {
                        sender.AddressEmail = req.Email;
                        sender.Password = req.Password;
                        sender.UpDateTime = DateTime.Now;
                        _context.SaveChanges();
                        return new() { IsSuccess = true, Message = "عملیات با موفقیت انجام شد." };
                    }
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = valid.Errors[0].ErrorMessage };
            }
            return new() { IsSuccess = false, Message = "ارسال کننده پیدا نشد." };
        }
    }
    public class RequestEditSenderEmailDtoValidation : AbstractValidator<RequestEditSenderEmailDto>
    {
        public RequestEditSenderEmailDtoValidation()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("ارسال کنندده پیدا نشد");
            RuleFor(p => p.Email).NotEmpty().WithMessage("لطفا ادرس ارسال کننده را وارد کنید.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("لطفا گذرواژه ارسال کننده را وارد کنید.");
        }
    }
}
