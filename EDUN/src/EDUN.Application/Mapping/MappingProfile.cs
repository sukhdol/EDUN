using AutoMapper;
using EDUN.Application.Resources;
using EDUN.Domain.Entities;

namespace EDUN.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain To API Resource
            CreateMap<Item, ItemResource>();
            
            // API Resource to Domain
            CreateMap<ItemResource, Item>();
        }
    }
}