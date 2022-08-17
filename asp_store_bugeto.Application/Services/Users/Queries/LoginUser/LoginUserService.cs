using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Users.Queries.LoginUser
{
    public class LoginUserService : ILoginUserService
    {
        private readonly IDataBaseContext _context;
        public LoginUserService(IDataBaseContext context)
        {
            _context = context;

        }

        public ResultDto<LoginDto> Execut(RequestLoginDto request)
        {
            RequestLoginDtoValidator validationRules = new();
            var result = validationRules.Validate(request);
            if (result.IsValid)
            {
                var user = _context.Users.Include(p => p.UserInRoles).ThenInclude(p => p.Role).Where(p => (p.FullName.Equals(request.UserName) && p.IsActive == true) || (p.Email.Equals(request.UserName) && p.IsActive == true)).FirstOrDefault();
                if (user != null)
                {
                    if (HasherText.CheckVerifyHashText(user.Password, request.Password))
                    {
                        var roles = new List<RolesDto>();
                        foreach (var item in user.UserInRoles)
                        {
                            roles.Add(new RolesDto() { Id = item.Role.Id, Name = item.Role.Name });
                        }
                        return new ResultDto<LoginDto>() { IsSuccess = true, Message = "کاربر با موفقیت وارد شد", Data = new LoginDto() { FullName = user.FullName, Roles = roles, UserId = user.Id, Email = user.Email } };
                    }
                }
                return new ResultDto<LoginDto>() { IsSuccess = false, Message = "ورود ناموفق لطفا اطلاعات خود را چک کرده و مجددا اقدام به ورود نمایید.", Data = new LoginDto() { } };
            }
            else
            {
                return new ResultDto<LoginDto>() { IsSuccess = false, Message = result.Errors[0].ErrorMessage, Data = new LoginDto() };
            }

        }
    }
}
