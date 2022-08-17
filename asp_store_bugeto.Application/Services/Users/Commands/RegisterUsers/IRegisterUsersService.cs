using asp_store_bugeto.Common.Dto;

namespace asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers
{
    public interface IRegisterUsersService
    {
        ResultDto<ResultRegisterUsers> Execute(RequestRegisterUserDto request);
    }
}
