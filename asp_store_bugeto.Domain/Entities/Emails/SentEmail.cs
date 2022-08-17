using asp_store_bugeto.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Emails
{
    public class SentEmail 
    {
        public long Id { get; set; }
        public string UserEmail { get; set; }
        public DateTime SendingTime { get; set; }
        public string Subject { get; set; }
    }
}
