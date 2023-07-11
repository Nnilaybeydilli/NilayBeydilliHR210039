using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ETicaret.DataAccessLayer.Mappings
{
    /// <summary>
    /// Customer entity veritabanı modellemesi
    /// </summary>
    public class ShoppingCartMap : IEntityTypeConfiguration<ShoppingCart>
    {

        public void Configure(EntityTypeBuilder<ShoppingCart> modelBuilder)
        {
            modelBuilder.ToTable("ShoppingCart");
                         


            modelBuilder.HasKey("cartid");
            modelBuilder.Property(x => x.cartid).HasColumnName("CartID").HasColumnType("int").IsRequired();
            modelBuilder.Property(x => x.quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();
            modelBuilder.Property(x => x.price).HasColumnName("Price").HasColumnType("int").IsRequired();
            modelBuilder.Property(x => x.productID).HasColumnName("ProductID").HasColumnType("int").IsRequired();
            modelBuilder.Property(x => x.Status).HasColumnName("Status").HasColumnType("bit").IsRequired();



            modelBuilder.HasData(new ShoppingCart
            {
                cartid=1,
                quantity=1,
                price=1,
                productID=1,
                Status=true,

            });




        }
    }
}
