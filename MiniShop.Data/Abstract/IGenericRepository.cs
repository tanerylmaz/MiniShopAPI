using System;
namespace MiniShop.Data.Abstract
{
	public interface IGenericRepository<TEntity> where TEntity :class
	{
		Task<TEntity> GetByIdAsync(int id);
		Task<List<TEntity>> GetAllAsync();
		Task<TEntity> CreateAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task HardDeleteAsync(TEntity entity);
    }
}

