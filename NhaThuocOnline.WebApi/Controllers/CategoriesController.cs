﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Application.Service;
using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.ViewModel.Category;

namespace NhaThuocOnline.WebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory() { 
            var data= await _categoryService.GetAllCategories();
            return Ok(data);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CategoryCreateRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _categoryService.CreateCategory(request);
            if (result)
                return Ok(result);

            return BadRequest(result);
        }

    }
}
