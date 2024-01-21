using System;
namespace MiniShop.Entity.Abstract
{
	public abstract class BaseEntity
	{
		public string Id { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime ModifiedDate { get; set; } = DateTime.Now;
		public string Name { get; set; }
		public bool IsActive { get; set; } = true;
		public bool IsDeleted { get; set; }
		public string Url { get; set; }
	}
}

