using System;
using MiniShop.Shared.DTOs.Product;

namespace MiniShop.Shared.DTOs.Category
{
	public class EditCategoryDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime ModifiedDate { get; set; }

	}
}

