using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Products;
using asp_store_bugeto.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Carts
{
    public class Carts : BaseEntity
    {
        public User User { get; set; }
        public long? UserID { get; set; }
        public Guid BrowserId { get; set; }
        public bool Finished { get; set; } = false;
        public ICollection<CartItem> CartItems { get; set; }
    }
    public class CartItem : BaseEntity
    {
        public Carts Cart { get; set; }
        public long CartID { get; set; }
        public Product Product { get; set; }
        public long ProductID { get; set; }
        public int Price { get; set; }
        public int CountItem { get; set; }


    }
}
