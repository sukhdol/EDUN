using System.Collections.Generic;

namespace EDUN.Application.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemResource> Items { get; set; }
    }
}