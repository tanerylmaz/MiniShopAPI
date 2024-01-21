using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Url).IsRequired().HasMaxLength(50);

            builder.ToTable("Categories");


            builder
               .HasData(
                   new Category
                   {
                       Id = 1,
                       Name = "Televizyon",
                       Description = "TV kategorisi",
                       Url = "televizyon"
                   },
                   new Category
                   {
                       Id = 2,
                       Name = "Bilgisayar",
                       Description = "Bilgisayar kategorisi",
                       Url = "bilgisayar"
                   },
                   new Category
                   {
                       Id = 3,
                       Name = "Elektronik Eşya",
                       Description = "Elektronik Eşya kategorisi",
                       Url = "elektronik-esya"
                   },
                   new Category
                   {
                       Id = 4,
                       Name = "Beyaz Eşya",
                       Description = "Beyaz Eşya kategorisi",
                       Url = "beyaz-esya"
                   },
                   new Category
                   {
                       Id = 5,
                       Name = "Telefon",
                       Description = "Telefon kategorisi",
                       Url = "telefon"
                   }
               );
        }
    }
}

