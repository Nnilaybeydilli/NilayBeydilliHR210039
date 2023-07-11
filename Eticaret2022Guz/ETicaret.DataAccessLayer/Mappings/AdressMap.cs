using Eticaret.Core.Models;
using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class AdressMap : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> modelBuilder)
        {
            modelBuilder.ToTable("Adress");
            modelBuilder.HasKey("AdressId");
            modelBuilder.Property(x => x.AdressId)
                .HasColumnName("AdressID");
            modelBuilder.Property(x => x.AdressName)
                .HasColumnName("AdressName")
                .HasColumnType("nvarchar").
                HasMaxLength(200).
                IsRequired();
            modelBuilder.Property(x => x.CityName).
                HasColumnName("CityName").
                HasColumnType("nvarchar").
                HasMaxLength(60).IsRequired();
            modelBuilder.Property(x => x.TownName).
                HasColumnName("TownName").
                HasColumnType("nvarchar").
                HasMaxLength(200);
            modelBuilder.Property(x => x.NeighborhoodName).HasColumnName("NeighborhoodName").HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.AdressDescription).HasColumnName("AdressDescription").HasColumnType("nvarchar").HasMaxLength(200);


            modelBuilder.HasData(new Adress
            {
                AdressId = 1,
                AdressName = "istanbul",
                CityName = "kartal",
                TownName = "cumhuriyet mah",
                NeighborhoodName = "tertip sk",
                AdressDescription = "türkiye",
                AdressStatus=true,
            }) ;
        }
    }
}
