using System.Threading.Tasks;
using EDUN.Application.Resources;
using EDUN.Application.Services;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using EDUN.Domain.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EDUN.WebUI.Controllers
{
    [Route("/api/items")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] ItemResource newItemResource)
        {
            var result = await _itemService.CreateItem(newItemResource);
            
            return Ok(result);
        } 
    }
}