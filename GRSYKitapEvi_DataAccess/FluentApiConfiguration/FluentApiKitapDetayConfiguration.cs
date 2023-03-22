using GRSYKitapEvi_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_DataAccess.FluentApiConfiguration
{
    public class FluentApiKitapDetayConfiguration : IEntityTypeConfiguration<FluentApi_KitapDetay>
    {
        public void Configure(EntityTypeBuilder<FluentApi_KitapDetay> modelBuilder)
        {
            // FlutentApi_KitapDetay 
            modelBuilder.HasKey(a => a.KitapDetay_Id);
            modelBuilder.Property(a => a.BolumSayisi).IsRequired();

        }
    }
}
