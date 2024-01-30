using System;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
	public interface ICategoryRepository : IGenericRepository<Category>
	{
		Task<List<Category>> GetAllCategoriesWithProductsAsync();
		Task<List<Category>> GetAllCategoriesActiveDeletedAsync(bool? isActive = null, bool? isDeleted = null);
		Task<Category> GetCategoryWithProductsAsync(int id);
	}
}

