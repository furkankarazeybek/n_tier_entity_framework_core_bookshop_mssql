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
    public class FluentApiYazarConfiguration : IEntityTypeConfiguration<FluentApi_Yazar>
    {
        public void Configure(EntityTypeBuilder<FluentApi_Yazar> modelBuilder)
        {
            //FluentApi_Yazar

            modelBuilder.HasKey(a => a.Yazar_Id);
            modelBuilder.Property(a => a.YazarAd).IsRequired();
            modelBuilder.Property(a => a.YazarSoyad).IsRequired();
            modelBuilder.Ignore(a => a.AdSoyad);  //not mapped
        }
    }
}