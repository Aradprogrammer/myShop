using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_store_bugeto.Domain.Entities.Users;

namespace asp_store_bugeto.Application.Services.Emails.Commands.SendEmail
{
    public class ResultUserApprovalsDto
    {
        public bool UserExistence { get; set; }
        public bool UserIsActive { get; set; }
        public User? user { get; set; }
    }
}
