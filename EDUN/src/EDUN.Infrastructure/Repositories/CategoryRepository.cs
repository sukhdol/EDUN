using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDUN.Application.Common.Interfaces;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EDUN.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CategoryRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public async Task<IEnumerable<Category>> GetCategories(bool includeRelated = true)
        {
            if (!includeRelated)
            {
                return await _applicationDbContext.Categories.ToListAsync();
            }

            return await _applicationDbContext.Categories.Include(c => c.Items).ToListAsync();
        }
    }
}