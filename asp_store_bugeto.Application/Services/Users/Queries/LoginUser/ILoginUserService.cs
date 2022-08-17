using asp_store_bugeto.Common.Dto;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Queries.LoginUser
{
    public interface ILoginUserService
    {
        ResultDto<LoginDto> Execut(RequestLoginDto request);
    }
}
