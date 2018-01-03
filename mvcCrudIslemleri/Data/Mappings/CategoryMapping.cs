using mvcCrudIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace mvcCrudIslemleri.Data.Mappings
{
    public class CategoryMapping: EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasKey<int>(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("KategoriID");

            Property(x => x.Name)
                .HasMaxLength(50)
                .HasColumnName("Ürün Adı")
                .IsRequired()
                .IsUnicode()
                .HasColumnOrder(1);

            Property(x => x.Description)
                .HasMaxLength(200)
                .HasColumnName("Açıklama")
                .IsOptional()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasColumnOrder(2);
            ToTable("Kategori Tablosu");

        }
    }
}