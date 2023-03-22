using GRSYKitapEvi_Model.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_DataAccess.FluentApiConfiguration
{

   public class FluentApiKitapConfiguration : IEntityTypeConfiguration<FluentApi_Kitap>
        {
            public void Configure(EntityTypeBuilder<FluentApi_Kitap> modelBuilder)
            {
                //FluentApi_Kitap 
                modelBuilder.HasKey(a => a.Kitap_Id);
                modelBuilder.Property(a => a.KitapAdı).IsRequired();
                modelBuilder.Property(a => a.Fiyat).IsRequired();
                modelBuilder.Property(a => a.ISBN).IsRequired().HasMaxLength(13);


            //FluentApi_Kitap(foreign) - FluentApi_KitapDetay(primary) , bire bir ilişki
            modelBuilder.HasOne(a => a.FluentApi_KitapDetay).WithOne(a => a.FluentApi_Kitap).HasForeignKey<FluentApi_Kitap>("KitapDetayIdForeign");

            //FluentApi_Kitap(foreign) - FluentApi_Yayinevi(primary) - Bire çok ilişki
            modelBuilder.HasOne(a => a.FluentApi_Yayinevi).WithMany(a => a.FluentApi_Kitap).HasForeignKey(a => a.YayinEviIdForeign);
        }
        }
    }
