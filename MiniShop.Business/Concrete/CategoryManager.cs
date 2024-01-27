using System;
using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Shared.DTOs.Category;

namespace MiniShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryManager(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllCategoriesWithProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}

