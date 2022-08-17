using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Domain.Entities.Emails;
using System;
using System.Collections.Generic;
using FluentValidation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Emails.Commands.AddSenderEmail
{
    public interface IAddSenderEmailService
    {
        public ResultDto Execute(RequestAddSenderDto req);
    }

    public class RequestAddSenderDto
    {
        public string Address { get; set; }
        public string Password { get; set; }

    }
    public class AddSenderRequestValidation : AbstractValidator<RequestAddSenderDto>
    {
        public AddSenderRequestValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("لطفا ایمیل را وارد کنید!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("لطفا رمز عبور را وارد کنید!");
            RuleFor(x => x.Address).Must(CheckEmail).WithMessage("لطفا ایمیل را به صورت درست وارد کنید!");
        }
        public static bool CheckEmail(string Email)
        {
            if (Email != null)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(Email, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
    public class AddSenderEmailService : IAddSenderEmailService
    {
        private readonly IDataBaseContext _context;
        public AddSenderEmailService(IDataBaseContext context)
        {
            _context = context;

        }
        public ResultDto Execute(RequestAddSenderDto req)
        {

            SenderEmail Sender = new() { InsertTime = DateTime.Now, AddressEmail = req.Address, Password = req.Password };
            var check = new AddSenderRequestValidation();
            var validat = check.Validate(req);
            if (validat.IsValid)
            {
                try
                {
                    _context.SenderEmails.Add(Sender);
                    _context.SaveChanges();
                    return new() { IsSuccess = true, Message = "ایمیل با موفقیت ثبت شد." };
                }
                catch (Exception ex)
                {
                    return new() { IsSuccess = false, Message = ex.Message };
                }
            }
            else
            {
                return new() { IsSuccess = false, Message = validat.Errors[0].ErrorMessage };
            }
        }
    }
}
