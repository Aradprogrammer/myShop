using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Domain.Entities.Commons
{
	public abstract class BaseEntity<TKey>
	{
		public TKey Id { get; set; }
		public DateTime InsertTime { get; set; } = DateTime.Now;
		public DateTime? UpDateTime { get; set; }
		public bool IsRemoved { get; set; } = false;
		public DateTime? Removetime { get; set; }
	}
	public abstract class BaseEntity : BaseEntity<long>
	{

	}
}
