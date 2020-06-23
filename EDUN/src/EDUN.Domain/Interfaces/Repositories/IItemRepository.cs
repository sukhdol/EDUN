using System.Threading.Tasks;
using EDUN.Domain.Entities;

namespace EDUN.Domain.Interfaces.Repositories
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Remove(Item item);

        Task<Item> GetItem(int id, bool includeRelated = true);
    }
}