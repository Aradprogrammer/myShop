using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Finances
{
    public class RequestPay : BaseEntity
    {
        public Guid Guid { get; set; }
        public virtual User User { get; set; }
        public long UserID { get; set; }
        public int Amount { get; set; }
        public bool isPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public int RefId { get; set; } = 0;

    }
}
