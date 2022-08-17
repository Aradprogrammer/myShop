using asp_store_bugeto.Application.Services.Users.Queries.GetUsers;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Queries.GetUserByEmail
{
    public interface IGetUserByEmailService
    {
        public ResultDto<GetUsersDto> Execute(string Email);
    }
}
