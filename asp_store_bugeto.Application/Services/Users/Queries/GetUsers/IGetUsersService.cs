using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ReslutGetUserDto Execute(RequestGetUserDto request);
    }
}
