﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyStoreProject.Models;

namespace MyStoreProject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190115041007_AddLoai4HangHoa")]
    partial class AddLoai4HangHoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyStoreProject.Models.DanhGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Diem");

                    b.Property<int>("MaHH");

                    b.Property<string>("MaKH")
                        .HasMaxLength(10);

                    b.Property<DateTime>("NgayDanhGia");

                    b.HasKey("Id");

                    b.HasIndex("MaHH");

                    b.HasIndex("MaKH");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("MyStoreProject.Models.HangHoa", b =>
                {
                    b.Property<int>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChiTiet");

                    b.Property<double>("DonGia");

                    b.Property<double>("GiamGia");

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoai");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenHH")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaHh");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("MyStoreProject.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<bool>("DangHoatDong");

                    b.Property<string>("DienThoai");

                    b.Property<string>("Email");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MatKhau")
                        .IsRequired();

                    b.Property<string>("TenDangNhap")
                        .IsRequired();

                    b.HasKey("MaKH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("MyStoreProject.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoaiCha");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("MyStoreProject.Models.DanhGia", b =>
                {
                    b.HasOne("MyStoreProject.Models.HangHoa", "HangHoa")
                        .WithMany()
                        .HasForeignKey("MaHH")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyStoreProject.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKH");
                });

            modelBuilder.Entity("MyStoreProject.Models.HangHoa", b =>
                {
                    b.HasOne("MyStoreProject.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}