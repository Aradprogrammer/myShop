using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using FluentValidation;
using asp_store_bugeto.Common;

namespace asp_store_bugeto.Application.Services.Users.Commands.EditeUser
{
    public class RequestEditeUserPasswordValidator : AbstractValidator<UserEditeDto>
    {
        public RequestEditeUserPasswordValidator()
        {
            RuleFor(p => p.Password).NotNull().WithMessage("لطفا گذرواژه را وارد کنید");
            RuleFor(p => p.Password).NotEmpty().WithMessage("لطفا گذرواژه را وارد کنید.");
            RuleFor(p => p.RePassword).NotNull().WithMessage("لطفا تکرار گذرواژه را وارد کنید.");
            RuleFor(p => p.RePassword).NotEmpty().WithMessage("لطفا تکرار گذرواژه را وارد کنید.");
            RuleFor(p => p.RePassword).Equal(p => p.Password).WithMessage("لطفا تکرار گذرواژه را به درستی وارد کنید.");
        }
    }
    public class RequestEditeUserValidator : AbstractValidator<UserEditeDto>
    {
        public RequestEditeUserValidator()
        {
            RuleFor(p => p.FullName).NotEmpty().WithMessage("لطفا نام کاربری خود را وارد کنید.");
        }
    }
    public class EditeUserService : IEditeUserService
    {
        private readonly IDataBaseContext _context;
        public EditeUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(string FullName, long UserId, string Password = "", string RePassword = "")
        {
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto() { IsSuccess = false, Message = "کاربر یافت نشد" };
            }
            else
            {
                user.FullName = FullName;

                if (!string.IsNullOrEmpty(Password))
                {
                    RequestEditeUserPasswordValidator validat = new();
                    var request = new UserEditeDto() { Id = UserId, FullName = FullName, Password = Password, RePassword = RePassword };
                    var result = validat.Validate(request);
                    if (result.IsValid)
                    {
                        user.Password = HasherText.Hash(Password);     
                    }  
                }
                _context.SaveChanges();
                return new ResultDto() { IsSuccess = true, Message = "اطلاعات کاربر با موفقیت ویرایش شد." };
            }
        }
    }

}
