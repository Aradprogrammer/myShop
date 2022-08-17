using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Services.Users.Queries.GetUsers;
using asp_store_bugeto.Common.Dto;
using System.Linq;

namespace asp_store_bugeto.Application.Services.Users.Queries.GetUserByEmail
{
    public class GetUserByEmailService : IGetUserByEmailService
    {
        private readonly IDataBaseContext _context;
        public GetUserByEmailService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<GetUsersDto> Execute(string Email)
        {
            var user = _context.Users.Where(p => p.Email == Email).FirstOrDefault();
            if (user == null)
            {
                return new() { IsSuccess = false, Message = "کاربر یافت نشد." };
            }
            else
            {


                return new ResultDto<GetUsersDto>()
                {
                    IsSuccess = true,
                    Data = new() { Id = user.Id, Email = Email, FullName = user.FullName, IsActive = user.IsActive },
                    Message = "کاربر با موفقیت یافت شد."
                };
            }
        }
    }
}
