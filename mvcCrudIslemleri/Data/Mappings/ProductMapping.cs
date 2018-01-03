using mvcCrudIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace mvcCrudIslemleri.Data.Mappings
{
    public class ProductMapping:EntityTypeConfiguration<Product>
    {
        //HLuent Api ile POCO sınfılarının database tarıfında konfigirasyon yapılma işlemi
        public ProductMapping()
        {
            Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(20).HasColumnName("Ürün Adı")
                .HasColumnOrder(1);

            Property(x => x.Price)
                .HasPrecision(16, 2)
                .HasColumnName("Fiyat")
                .HasColumnType("decimal")
                .HasColumnOrder(2);

            Property(x => x.Stock)
                
                .HasColumnName("Sok Miktari")
                .HasColumnOrder(3)
                .HasColumnType("int");

            HasKey<int>(x => x.Id);


        }
    }
}