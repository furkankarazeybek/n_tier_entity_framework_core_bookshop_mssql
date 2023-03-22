﻿// <auto-generated />
using System;
using GRSYKitapEvi_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230320090252_BirebirİliskiKitapveKitapDetayDB")]
    partial class BirebirİliskiKitapveKitapDetayDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ad");

                    b.HasKey("KategoriId");

                    b.ToTable("tb_Kategori");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kitap", b =>
                {
                    b.Property<int>("Kitap_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("KategoriIdForeign")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapDetayIdForeign")
                        .HasColumnType("int");

                    b.HasKey("Kitap_Id");

                    b.HasIndex("KategoriIdForeign");

                    b.HasIndex("KitapDetayIdForeign");

                    b.ToTable("tb_Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.KitapDetay", b =>
                {
                    b.Property<int>("KitapDetay_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Agirlik")
                        .HasColumnType("float");

                    b.Property<int>("BolumSayisi")
                        .HasColumnType("int");

                    b.Property<int>("KitapSayfasi")
                        .HasColumnType("int");

                    b.HasKey("KitapDetay_Id");

                    b.ToTable("KitapDetaylari");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Tur", b =>
                {
                    b.Property<int>("TurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TurAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurId");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.YayınEvi", b =>
                {
                    b.Property<int>("YayinEvi_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lokasyon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayinEviAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayinEvi_Id");

                    b.ToTable("tb_YayinEvi");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Yazar", b =>
                {
                    b.Property<int>("Yazar_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Yazar_Id");

                    b.ToTable("tb_Yazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kitap", b =>
                {
                    b.HasOne("GRSYKitapEvi_Model.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRSYKitapEvi_Model.Models.KitapDetay", "KitapDetay")
                        .WithMany()
                        .HasForeignKey("KitapDetayIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("KitapDetay");
                });
#pragma warning restore 612, 618
        }
    }
}
