using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs.Category;

namespace MiniShop.API.Controllers
{
    [Route("[controller]")]
   // [Route("[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
       private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }


        [HttpGet("getwithproducts")]
        public async Task<IActionResult> GetWithProducts()
        {
            var response = await _categoryManager.GetAllCategoriesWithProductsAsync();
            var result = JsonSerializer.Serialize(response);
            return Ok(result);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var jsonresp = JsonSerializer.Serialize(response);
            return Ok(jsonresp);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(AddCategoryDTO addCategoryDTO)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDTO);
            var jsonresp = JsonSerializer.Serialize(response);
            return Ok(jsonresp);
        }

        [HttpPut("update")] //güncelleme işlemlerinde kullanılır
        public async Task<IActionResult> Update(EditCategoryDTO editCategoryDTO)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDTO);
            var jsonresp = JsonSerializer.Serialize(response);
            return Ok(jsonresp);
        }

        [HttpDelete("harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            var jsonresp = JsonSerializer.Serialize(response);
            return Ok(jsonresp);
        }

        [HttpDelete("softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            var jsonresp = JsonSerializer.Serialize(response);
            return Ok(jsonresp);
        }
    }
}

