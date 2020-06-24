using System.Collections.Generic;
using System.Threading.Tasks;
using EDUN.Application.Resources;

namespace EDUN.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResource>> GetCategories(bool includeRelated = true);
    }
}