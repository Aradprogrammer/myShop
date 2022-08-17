using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Users.Queries.LoginUser
{
    public class LoginDto
    {
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<RolesDto> Roles { get; set; }
    }
}
