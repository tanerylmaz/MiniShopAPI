using System;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Context;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MiniShopDbContext _context) : base(_context)
        {
        }
        private  MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Product>> GetAllProductsWithCategoriesAsync()
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(pc => pc.ProductCategories)
                .ThenInclude(p => p.Category)
                .ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            List<Product> products = await MiniShopDbContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId))
                .ToListAsync();
            return products;
        }

        public async Task<Product> GetProductWithCategoriesAsync(int id)
        {
            Product product = await MiniShopDbContext
                .Products
                .Where(p => p.Id == id)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .SingleOrDefaultAsync();
            return product;
        }
    }
}

