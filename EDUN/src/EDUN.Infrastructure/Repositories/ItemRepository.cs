using System.Threading.Tasks;
using EDUN.Application.Common.Interfaces;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EDUN.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public ItemRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public void Add(Item item)
        {
            _applicationDbContext.Items.Add(item);
        }

        public void Remove(Item item)
        {
            _applicationDbContext.Items.Remove(item);
        }

        public async Task<Item> GetItem(int id, bool includeRelated = true)
        {
            // return Item only
            if (!includeRelated)
            {
                return await _applicationDbContext.Items.FindAsync(id);
            }

            // return Item with Category info
            return await _applicationDbContext.Items
                            .Include(i => i.Category)
                            .SingleOrDefaultAsync(i => i.Id == id);
        }
    }
}