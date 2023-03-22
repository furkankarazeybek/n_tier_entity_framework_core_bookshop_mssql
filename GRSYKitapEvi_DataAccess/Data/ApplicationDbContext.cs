using GRSYKitapEvi_DataAccess.FluentApiConfiguration;
using GRSYKitapEvi_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //constructor


        }

        //DATA ANNOTİON 

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Tur> Turler { get; set; }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KitapDetay> KitapDetaylari { get; set; }


        public DbSet<YayınEvi> Yayinevleri { get; set; }

        public DbSet<Yazar> Yazarlar { get; set; }

        public DbSet<KitapYazar> KitaplarYazarlar { get; set; }

        //data annotion */


        //FLUENT API

        public DbSet<FluentApi_KitapDetay> FluentApi_KitapDetaylar { get; set; }

        public DbSet<FluentApi_Kitap> FluentApi_Kitaplar { get; set; }
        public DbSet<FluentApi_Yazar> FluentApi_Yazar{ get; set; }
        public DbSet<FluentApi_YayınEvi> FluentApi_YayınEvi { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composit key 
            modelBuilder.Entity<KitapYazar>().HasKey(x => new { x.Yazar_Id, x.Kitap_Id }); 



            //Kategori Tablo Ad ve Kolon Ad
            modelBuilder.Entity<Kategori>().ToTable("tbl_Kategori");
            modelBuilder.Entity<Kategori>().Property(b => b.KategoriAd).HasColumnName("KategoriAdi");


            modelBuilder.ApplyConfiguration(new FluentApiKitapDetayConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiKitapConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiKitapYazarConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiYayineviConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiYazarConfiguration());
        }



    }
}
