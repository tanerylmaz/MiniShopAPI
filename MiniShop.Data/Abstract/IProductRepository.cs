using System;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Abstract
{
	public interface IProductRepository :IGenericRepository<Product>
	{
        Task<List<Product>> GetAllProductsWithCategoriesAsync();
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
        Task<Product> GetProductWithCategoriesAsync(int id);

    }
}

