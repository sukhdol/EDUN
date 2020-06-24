using System.Collections.Generic;
using System.Threading.Tasks;
using EDUN.Application.Resources;
using EDUN.Application.Services;
using EDUN.Application.Services.Interfaces;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EDUN.WebUI.Controllers
{
    [Route("/api/categories")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories(bool includeRelated)
        {
            return await _categoryService.GetCategories(true);
        }
    }
}