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
    public class FluentApiKitapYazarConfiguration : IEntityTypeConfiguration<FluentApi_KitapYazar>
    {
        public void Configure(EntityTypeBuilder<FluentApi_KitapYazar> modelBuilder)
        {
            //FluentApi_Kitap - Fluent_Api_Yazar , çoka çok ilişki
            modelBuilder.HasKey(ab => new { ab.Yazar_Id, ab.Kitap_Id });
            modelBuilder.HasOne(a => a.Fluent_Kitap).WithMany(a => a.FluentApi_KitaplarYazarlar).HasForeignKey(a => a.Kitap_Id);
            modelBuilder.HasOne(a => a.Fluent_Yazar).WithMany(a => a.FluentApi_KitaplarYazarlar).HasForeignKey(a => a.Yazar_Id);
        }
    }
}
