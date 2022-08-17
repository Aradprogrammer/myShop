using asp_store_bugeto.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.HomePage
{
    public class PicAndLink : BaseEntity
    {
        public string Link { get; set; }
        public string Src { get; set; }
        public string Location { get; set; }
    }
}
