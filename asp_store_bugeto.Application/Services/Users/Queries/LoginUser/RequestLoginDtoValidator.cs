using FluentValidation;

namespace asp_store_bugeto.Application.Services.Users.Queries.LoginUser
{
    public class RequestLoginDtoValidator : AbstractValidator<RequestLoginDto>
    {
        public RequestLoginDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("لطفا نام کاربری یا ایمیل را وارد کنید.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("لطفا گذرواژه را وارد کنید.");
        }
    }
}
