using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using asp_store_bugeto.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Services.Roles.GetRoleByName
{
    public interface IGetRoleByNameService
    {
        public ResultDto<RolesDto> Execut(string RoleName);
    }

}
