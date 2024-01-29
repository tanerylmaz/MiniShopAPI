using System;
using MiniShop.Shared.DTOs.Category;
using MiniShop.Shared.ResponseDTOs;

namespace MiniShop.Business.Abstract
{
	public interface ICategoryService
	{
        #region Generic

        Task<Response<CategoryDTO>> GetByIdAsync(int id);

        Task<Response<List<CategoryDTO>>> GetAllAsync();

        Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO);

        Task<Response<CategoryDTO>> UpdateAsync(CategoryDTO categoryDTO);

        Task<Response<NoContent>> HardDeleteAsync(int id);

        Task<Response<NoContent>> SoftDeleteAsync(int id);

        #endregion

        #region Category

        Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductsAsync();

        #endregion
    }
}

