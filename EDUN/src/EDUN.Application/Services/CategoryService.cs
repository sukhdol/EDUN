using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EDUN.Application.Resources;
using EDUN.Application.Services.Interfaces;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;

namespace EDUN.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepo;

        public CategoryService(IMapper mapper,
                                ICategoryRepository categoryRepo)
        {
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }

        public async Task<IEnumerable<CategoryResource>> GetCategories(bool includeRelated = true)
        {
            var categoriesInDb = await _categoryRepo.GetCategories(includeRelated);

            var result = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categoriesInDb);

            return result;
        }

        public async Task<IEnumerable<KeyValuePairResource>> GetCategoriesKeyValuePair()
        {
            var categoriesInDb = await _categoryRepo.GetCategories(includeRelated: false);

            var result = _mapper.Map<IEnumerable<Category>, IEnumerable<KeyValuePairResource>>(categoriesInDb);

            return result;
        }
    }
}