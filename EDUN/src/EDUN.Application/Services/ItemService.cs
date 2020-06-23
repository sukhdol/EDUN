using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EDUN.Application.Resources;
using EDUN.Domain.Entities;
using EDUN.Domain.Interfaces.Repositories;
using EDUN.Domain.Interfaces.UnitOfWork;

namespace EDUN.Application.Services
{
    public interface IItemService
    {
        Task<Item> GetItem(int id, bool includeRelated = true);
        Task<ItemResource> CreateItem(ItemResource newItem);
    }
    
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepo;

        public ItemService(IUnitOfWork unitOfWork,
                            IMapper mapper,
                            IItemRepository itemRepo)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _itemRepo = itemRepo;
        }
        
        public async Task<Item> GetItem(int id, bool includeRelated = true)
        {
            return await _itemRepo.GetItem(id, includeRelated);
        }

        public async Task<ItemResource> CreateItem(ItemResource newItemResource)
        {
            var item = _mapper.Map<ItemResource, Item>(newItemResource);
            
            _itemRepo.Add(item);
            await _unitOfWork.Complete();

            var itemInDb = await GetItem(item.Id);
                
            var result = _mapper.Map<Item, ItemResource>(itemInDb);

            return result;
        }
    }
}