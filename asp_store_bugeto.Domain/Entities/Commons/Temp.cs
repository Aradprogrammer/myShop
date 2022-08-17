using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Commons
{
    public class Temp : BaseEntity
    {
        public string Value { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }

    }
}
