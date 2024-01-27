using System;
using MiniShop.Shared.DTOs.Category;

namespace MiniShop.Shared.DTOs.Product
{
	public class ProductDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Properties { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public string Url { get; set; }
		public List<CategoryDTO> Categories { get; set; }
	}
}

