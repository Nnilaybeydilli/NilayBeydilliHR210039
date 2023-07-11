using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {


            builder.Property(x => x.BrandId).HasDefaultValue(0);
          
            builder.Property(x => x.BrandName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.BrandStatu).HasColumnName("BrandStatu").HasDefaultValue(true).IsRequired();

            builder.HasData(new Brand
            {
                BrandId = 1,
                BrandName = "deneme",
                BrandStatu = true
                
            });
        }
    }
}
