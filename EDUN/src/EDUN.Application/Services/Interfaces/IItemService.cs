using System.Threading.Tasks;
using EDUN.Application.Resources;
using EDUN.Domain.Entities;

namespace EDUN.Application.Services.Interfaces
{
    public interface IItemService
    {
        Task<Item> GetItem(int id, bool includeRelated = true);
        Task<ItemResource> CreateItem(ItemResource newItem);
        void DeleteItem(Item itemToDelete);
    }
}