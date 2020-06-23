using System.Collections.Generic;
using System.Threading.Tasks;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EDUN.WebUI.Controllers
{
    [Route("/api/categories")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoriesController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryRepo.GetCategories(true);
        }
    }
}