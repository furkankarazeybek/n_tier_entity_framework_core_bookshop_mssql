﻿// <auto-generated />
using System;
using GRSYKitapEvi_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_Kitap", b =>
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

                    b.Property<string>("KitapAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapDetayIdForeign")
                        .HasColumnType("int");

                    b.Property<int>("YayinEviIdForeign")
                        .HasColumnType("int");

                    b.HasKey("Kitap_Id");

                    b.HasIndex("KitapDetayIdForeign")
                        .IsUnique();

                    b.HasIndex("YayinEviIdForeign");

                    b.ToTable("FluentApi_Kitaplar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_KitapDetay", b =>
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

                    b.ToTable("FluentApi_KitapDetaylar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_KitapYazar", b =>
                {
                    b.Property<int>("Yazar_Id")
                        .HasColumnType("int");

                    b.Property<int>("Kitap_Id")
                        .HasColumnType("int");

                    b.HasKey("Yazar_Id", "Kitap_Id");

                    b.HasIndex("Kitap_Id");

                    b.ToTable("FluentApi_KitapYazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_YayınEvi", b =>
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

                    b.ToTable("FluentApi_YayınEvi");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_Yazar", b =>
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

                    b.ToTable("FluentApi_Yazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("KategoriAdi");

                    b.HasKey("KategoriId");

                    b.ToTable("tbl_Kategori");
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

                    b.Property<int?>("KitapDetayIdForeign")
                        .HasColumnType("int");

                    b.Property<int>("YayınEviIdForeign")
                        .HasColumnType("int");

                    b.HasKey("Kitap_Id");

                    b.HasIndex("KategoriIdForeign");

                    b.HasIndex("KitapDetayIdForeign")
                        .IsUnique()
                        .HasFilter("[KitapDetayIdForeign] IS NOT NULL");

                    b.HasIndex("YayınEviIdForeign");

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

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.KitapYazar", b =>
                {
                    b.Property<int>("Yazar_Id")
                        .HasColumnType("int");

                    b.Property<int>("Kitap_Id")
                        .HasColumnType("int");

                    b.HasKey("Yazar_Id", "Kitap_Id");

                    b.HasIndex("Kitap_Id");

                    b.ToTable("KitaplarYazarlar");
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

                    b.ToTable("Yayinevleri");
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

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_Kitap", b =>
                {
                    b.HasOne("GRSYKitapEvi_Model.Models.FluentApi_KitapDetay", "FluentApi_KitapDetay")
                        .WithOne("FluentApi_Kitap")
                        .HasForeignKey("GRSYKitapEvi_Model.Models.FluentApi_Kitap", "KitapDetayIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRSYKitapEvi_Model.Models.FluentApi_YayınEvi", "FluentApi_Yayinevi")
                        .WithMany("FluentApi_Kitap")
                        .HasForeignKey("YayinEviIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentApi_KitapDetay");

                    b.Navigation("FluentApi_Yayinevi");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_KitapYazar", b =>
                {
                    b.HasOne("GRSYKitapEvi_Model.Models.FluentApi_Kitap", "Fluent_Kitap")
                        .WithMany("FluentApi_KitaplarYazarlar")
                        .HasForeignKey("Kitap_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRSYKitapEvi_Model.Models.FluentApi_Yazar", "Fluent_Yazar")
                        .WithMany("FluentApi_KitaplarYazarlar")
                        .HasForeignKey("Yazar_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluent_Kitap");

                    b.Navigation("Fluent_Yazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kitap", b =>
                {
                    b.HasOne("GRSYKitapEvi_Model.Models.Kategori", "Kategori")
                        .WithMany("Kitap")
                        .HasForeignKey("KategoriIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRSYKitapEvi_Model.Models.KitapDetay", "KitapDetay")
                        .WithOne("Kitap")
                        .HasForeignKey("GRSYKitapEvi_Model.Models.Kitap", "KitapDetayIdForeign");

                    b.HasOne("GRSYKitapEvi_Model.Models.YayınEvi", "YayınEvi")
                        .WithMany("Kitap")
                        .HasForeignKey("YayınEviIdForeign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("KitapDetay");

                    b.Navigation("YayınEvi");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.KitapYazar", b =>
                {
                    b.HasOne("GRSYKitapEvi_Model.Models.Kitap", "Kitap")
                        .WithMany("KitaplarYazarlar")
                        .HasForeignKey("Kitap_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRSYKitapEvi_Model.Models.Yazar", "Yazar")
                        .WithMany("KitaplarYazarlar")
                        .HasForeignKey("Yazar_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_Kitap", b =>
                {
                    b.Navigation("FluentApi_KitaplarYazarlar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_KitapDetay", b =>
                {
                    b.Navigation("FluentApi_Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_YayınEvi", b =>
                {
                    b.Navigation("FluentApi_Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.FluentApi_Yazar", b =>
                {
                    b.Navigation("FluentApi_KitaplarYazarlar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kategori", b =>
                {
                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Kitap", b =>
                {
                    b.Navigation("KitaplarYazarlar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.KitapDetay", b =>
                {
                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.YayınEvi", b =>
                {
                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Model.Models.Yazar", b =>
                {
                    b.Navigation("KitaplarYazarlar");
                });
#pragma warning restore 612, 618
        }
    }
}
