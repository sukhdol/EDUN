using System.Threading.Tasks;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using EDUN.Domain.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EDUN.WebUI.Controllers
{
    [Route("/api/items")]
    public class ItemsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemRepository _itemRepo;

        public ItemsController(IUnitOfWork unitOfWork,
                                IItemRepository itemRepo)
        {
            _unitOfWork = unitOfWork;
            _itemRepo = itemRepo;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] Item newItem)
        {
            _itemRepo.Add(newItem);
            await _unitOfWork.Complete();

            var itemInDb = _itemRepo.GetItem(newItem.Id);

            return Ok(itemInDb);
        } 
    }
}