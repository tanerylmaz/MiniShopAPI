using System;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs.Product;

namespace MiniShop.Business.Abstract
{
	public interface IProductService
    {

    #region Generic

        Task<ProductDTO> GetByIdAsync(int id);
        Task<List<ProductDTO>> GetAllAsync();
        Task<ProductDTO> CreateAsync(ProductDTO productDTO);
        Task<ProductDTO> UpdateAsync(ProductDTO productDTO);
        Task HardDeleteAsync(int id);
        Task SoftDeleteAsync(int id);
     #endregion


    #region Product

        Task<List<ProductDTO>> GetAllProductsWithCategoriesAsync();
        Task<List<ProductDTO>> GetProductsByCategoryIdAsync(int categoryId);
        Task<ProductDTO> GetProductWithCategoriesAsync(int id);

    #endregion

    }
}

