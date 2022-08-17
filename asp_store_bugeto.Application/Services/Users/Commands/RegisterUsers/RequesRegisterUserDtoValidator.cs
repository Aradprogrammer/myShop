using FluentValidation;

namespace asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers
{
    public class RequesRegisterUserDtoValidator: AbstractValidator<RequestRegisterUserDto>
    {
        public RequesRegisterUserDtoValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("لطفا نام کاربری خود را وارد کنید");
            
            RuleFor(x => x.Email).NotEmpty().WithMessage("لطفا ایمیل خود را وارد کنید");
            RuleFor(x => x.Email).Must(CheckEmailAddres).WithMessage("لطفا ایمیل خود را به درستی وارد کنید");

            RuleFor(p => p.Password).NotEmpty().WithMessage("لطفا گذرواژه را وارد کنید");
            RuleFor(p => p.Password).Length(8, 60).WithMessage("گذرواژه باید بیشتر از 8 کارکتر باشد");

            RuleFor(p => p.RePassword).NotEmpty().WithMessage("لطفا تکرار گذرواژه را وارد کنید");
            RuleFor(p => p.RePassword).Equal(p => p.Password).WithMessage("لطفا تکرار گذرواژه را به درستی وارد کنید");

            RuleFor(p => p.Roles).NotEmpty().WithMessage("لطفا یک نقش برای کاربر انتخاب کنید");
            
           
        }
        public static bool CheckEmailAddres(string email)
        {
            if (email != null)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(email, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
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
}
