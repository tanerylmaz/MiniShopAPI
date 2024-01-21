using System;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Context;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MiniShopDbContext _context) : base(_context)
        {
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Category>> GetAllCategoriesWithProductsAsync()
        {
            List<Category> categories = await MiniShopDbContext
                .Categories
                .Include(c=>c.ProductCategories)
                .ThenInclude(pc=>pc.Product)
                .ToListAsync();

            return categories;
        }
    }
}

