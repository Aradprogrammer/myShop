using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.HomePage
{
    public class SliderCategory : BaseEntity
    {
        public virtual Category? Category { get; set; }
        public long? CategoryId { get; set; }
        public string CategorySliderLocation { get; set; }
        public int CountItem { get; set; }
    }
}
