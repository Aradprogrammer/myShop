using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Users
{
    public class UserPopular : BaseEntity
    {
        public virtual User User { get; set; }
        public long UserId { get; set; }
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
    }
}
