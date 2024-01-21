using System;
using MiniShop.Entity.Abstract;

namespace MiniShop.Entity.Concrete
{
	public class Category : BaseEntity
	{
		public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

