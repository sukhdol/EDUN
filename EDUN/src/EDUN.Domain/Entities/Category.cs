using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDUN.Domain.Entities
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}