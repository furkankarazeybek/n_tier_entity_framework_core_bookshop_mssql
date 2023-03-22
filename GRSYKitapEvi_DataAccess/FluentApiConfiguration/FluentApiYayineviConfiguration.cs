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
    public class FluentApiYayineviConfiguration : IEntityTypeConfiguration<FluentApi_YayınEvi>
    {
        public void Configure(EntityTypeBuilder<FluentApi_YayınEvi> modelBuilder)
        {
            //FluentApi_Yayinevi

            modelBuilder.HasKey(a => a.YayinEvi_Id);
            modelBuilder.Property(a => a.YayinEviAdi).IsRequired();
            modelBuilder.Property(a => a.Lokasyon).IsRequired();
        }
    }
}
