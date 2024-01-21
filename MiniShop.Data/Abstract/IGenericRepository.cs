﻿using System;
namespace MiniShop.Data.Abstract
{
	public interface IGenericRepository<TEntity> where TEntity :class
	{
		Task<TEntity> GetByIdAsync(int id);
		Task<List<TEntity>> GetAllAsync();
		Task<TEntity> CreateAsync(TEntity entity);
		void Update(TEntity entity);
		void HardDelete(TEntity entity);
    }
}

