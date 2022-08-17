using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Users.Commands.EditeUser
{
    public interface IEditeUserService
    {
        public ResultDto Execute(string FullName, long UserId, string Password = "", string RePassword = "");
    }
}
