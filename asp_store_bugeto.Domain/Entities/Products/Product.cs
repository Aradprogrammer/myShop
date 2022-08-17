using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public bool Displayed { get; set; }
        public int AllStarsScore { get; set; } = 0;
        public int StarsCount { get; set; } = 5;
        public long VisitCount { get; set; } = 0;
        public long PopularCount { get; set; }

        public virtual Category Category { get; set; }
        public long CategoryID { get; set; }

        public ICollection<ProductImages> ProductImages { get; set; }
        public ICollection<ProductFeatures> ProductFeature { get; set; }
        public ICollection<UserPopular> UserPopular { get; set; }
    }
}
