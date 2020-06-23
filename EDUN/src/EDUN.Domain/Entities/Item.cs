using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EDUN.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Value { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
