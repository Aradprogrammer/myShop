using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Dto;
using asp_store_bugeto.Common;
using asp_store_bugeto.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers
{
    public class RegisterUsersService : IRegisterUsersService
    {
        private readonly IDataBaseContext _context;
        public RegisterUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultRegisterUsers> Execute(RequestRegisterUserDto request)
        {
            try
            {
                RequesRegisterUserDtoValidator validationRules = new();
                var result = validationRules.Validate(request);
                if (result.IsValid)
                {
                    var check = _context.Users.Where(p => p.Email.Equals(request.Email)).FirstOrDefault();
                    if (check ==null)
                    {
                        User user = new()
                        {
                            Email = request.Email,
                            FullName = request.FullName,
                            IsActive = true,
                            Password = HasherText.Hash(request.Password),
                        };
                        List<UserInRole> userInRoles = new();
                        foreach (var item in request.Roles)
                        {
                            var role = _context.Roles.Find((long)item.Id);
                            userInRoles.Add(new UserInRole()
                            {
                                Role = role,
                                RoleId = role.Id,
                                User = user,
                                UserId = user.Id,

                            });
                        }


                        user.UserInRoles = userInRoles;
                        _context.Users.Add(user);
                        _context.SaveChanges();



                        return new ResultDto<ResultRegisterUsers>()
                        {
                            Data = new ResultRegisterUsers()
                            {
                                userId = user.Id,
                            },
                            IsSuccess = true,
                            Message = "ثبت نام کاربر انجام شد"
                        };
                    }
                    else
                    {
                        return new ResultDto<ResultRegisterUsers>()
                        {
                            Data = new ResultRegisterUsers()
                            {

                            },
                            IsSuccess = false,
                            Message = "قبلا کاربری با این ایمیل/نام کاربری در سایت ثبت نام کرده است."
                        };
                    }

                }
                else
                {

                    return new ResultDto<ResultRegisterUsers>() { Data = new ResultRegisterUsers() { userId = 0 }, IsSuccess = false, Message = result.Errors[0].ErrorMessage };



                }
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultRegisterUsers>() { Data = new ResultRegisterUsers() { userId = 0 }, IsSuccess = false, Message = "یک خطای غیر منتظره رخ داد" + ex.Message };

            }
        }
    }
}
