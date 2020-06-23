using System.Collections.Generic;
using System.Threading.Tasks;
using EDUN.Domain.Entities;

namespace EDUN.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories(bool includeRelated = true);
    }
}