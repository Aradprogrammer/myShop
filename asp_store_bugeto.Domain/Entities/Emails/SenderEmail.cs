using asp_store_bugeto.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Emails
{
    public class SenderEmail : BaseEntity
    {
        public string AddressEmail { get; set; }
        public string Password { get; set; }
        public List<Email> Emails { get; set; }

    }
}
