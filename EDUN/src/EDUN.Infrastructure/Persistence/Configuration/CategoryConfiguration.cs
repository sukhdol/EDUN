using EDUN.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDUN.Infrastructure.Persistence.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Electronics"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Clothing"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Kitchen"
                    });
        }
    }
}