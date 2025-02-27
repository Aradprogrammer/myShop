﻿using System.Collections.Generic;

namespace asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public List<RolesInRequestRegisterUserDto> Roles { get; set; }
    }
}
