﻿// <auto-generated />
using System;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ECommerce.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongSP")
                        .HasColumnType("int");

                    b.Property<int>("SotienSP")
                        .HasColumnType("int");

                    b.Property<int>("TongTienDH")
                        .HasColumnType("int");

                    b.HasKey("MaDH", "MaSP");

                    b.ToTable("ChiTietDonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.DonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GhiChuDH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GiaoHangMaGH")
                        .HasColumnType("int");

                    b.Property<int?>("HoaDonMaHD")
                        .HasColumnType("int");

                    b.Property<string>("KhuyenMaiMaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaKM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTaoDH")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinhtrangDH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDH");

                    b.HasIndex("GiaoHangMaGH");

                    b.HasIndex("HoaDonMaHD");

                    b.HasIndex("KhuyenMaiMaKM");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.GiaoHang", b =>
                {
                    b.Property<int>("MaGH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaHD")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGiaoHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhanHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tinhtrang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaGH");

                    b.ToTable("GiaoHangs");
                });

            modelBuilder.Entity("ECommerce.Models.HoaDon", b =>
                {
                    b.Property<int>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GiaoHangMaGH")
                        .HasColumnType("int");

                    b.Property<int?>("KhachHangMaTK")
                        .HasColumnType("int");

                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaKH")
                        .HasColumnType("int");

                    b.Property<int>("MaNV")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NhanVienMaTK")
                        .HasColumnType("int");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.HasKey("MaHD");

                    b.HasIndex("GiaoHangMaGH");

                    b.HasIndex("KhachHangMaTK");

                    b.HasIndex("NhanVienMaTK");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("ECommerce.Models.KhachHang", b =>
                {
                    b.Property<int>("MaTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiemKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<int>("TenKh")
                        .HasColumnType("int");

                    b.HasKey("MaTK");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ECommerce.Models.Kho", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DonGiaNhap")
                        .HasColumnType("int");

                    b.Property<int?>("LoaiMaLoai")
                        .HasColumnType("int");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<int>("MaNhaCC")
                        .HasColumnType("int");

                    b.Property<int>("MaTH")
                        .HasColumnType("int");

                    b.Property<int?>("NhaCungCapMaNhaCC")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThuongHieuMaTH")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaSP");

                    b.HasIndex("LoaiMaLoai");

                    b.HasIndex("NhaCungCapMaNhaCC");

                    b.HasIndex("ThuongHieuMaTH");

                    b.ToTable("Khos");
                });

            modelBuilder.Entity("ECommerce.Models.KhuyenMai", b =>
                {
                    b.Property<string>("MaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChitietKhuyenMai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DieuKienApDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("MaKM");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("ECommerce.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("Loais");
                });

            modelBuilder.Entity("ECommerce.Models.NhaCungCap", b =>
                {
                    b.Property<int>("MaNhaCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaSoThue")
                        .HasColumnType("int");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<string>("TenNhaCC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhaCC");

                    b.ToTable("NhaCungCaps");
                });

            modelBuilder.Entity("ECommerce.Models.NhanVien", b =>
                {
                    b.Property<int>("MaTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhanViec")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<int>("TenNV")
                        .HasColumnType("int");

                    b.HasKey("MaTK");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ECommerce.Models.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ChiTietDonHangMaDH")
                        .HasColumnType("int");

                    b.Property<int?>("ChiTietDonHangMaSP")
                        .HasColumnType("int");

                    b.Property<string>("ChiTietSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KhoMaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongMuaToiThieu")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.HasIndex("KhoMaSP");

                    b.HasIndex("ChiTietDonHangMaDH", "ChiTietDonHangMaSP");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.ThuongHieu", b =>
                {
                    b.Property<string>("MaTH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTH");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("ECommerce.Models.TinTuc", b =>
                {
                    b.Property<int>("MaTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TieuDe")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTT");

                    b.ToTable("TinTucs");
                });

            modelBuilder.Entity("ECommerce.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("ECommerce.Models.DonHang", "DonHang")
                        .WithMany("ChiTietDonHang")
                        .HasForeignKey("MaDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("ECommerce.Models.DonHang", b =>
                {
                    b.HasOne("ECommerce.Models.GiaoHang", "GiaoHang")
                        .WithMany("DonHang")
                        .HasForeignKey("GiaoHangMaGH");

                    b.HasOne("ECommerce.Models.HoaDon", "HoaDon")
                        .WithMany("DonHang")
                        .HasForeignKey("HoaDonMaHD");

                    b.HasOne("ECommerce.Models.KhuyenMai", null)
                        .WithMany("DonHangs")
                        .HasForeignKey("KhuyenMaiMaKM");

                    b.Navigation("GiaoHang");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("ECommerce.Models.HoaDon", b =>
                {
                    b.HasOne("ECommerce.Models.GiaoHang", "GiaoHang")
                        .WithMany("HoaDon")
                        .HasForeignKey("GiaoHangMaGH");

                    b.HasOne("ECommerce.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangMaTK");

                    b.HasOne("ECommerce.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienMaTK");

                    b.Navigation("GiaoHang");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ECommerce.Models.Kho", b =>
                {
                    b.HasOne("ECommerce.Models.Loai", "Loai")
                        .WithMany("Khos")
                        .HasForeignKey("LoaiMaLoai");

                    b.HasOne("ECommerce.Models.NhaCungCap", "NhaCungCap")
                        .WithMany("Khos")
                        .HasForeignKey("NhaCungCapMaNhaCC");

                    b.HasOne("ECommerce.Models.ThuongHieu", "ThuongHieu")
                        .WithMany("Khos")
                        .HasForeignKey("ThuongHieuMaTH");

                    b.Navigation("Loai");

                    b.Navigation("NhaCungCap");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("ECommerce.Models.SanPham", b =>
                {
                    b.HasOne("ECommerce.Models.Kho", "Kho")
                        .WithMany("SanPhams")
                        .HasForeignKey("KhoMaSP");

                    b.HasOne("ECommerce.Models.ChiTietDonHang", "ChiTietDonHang")
                        .WithMany("SanPhams")
                        .HasForeignKey("ChiTietDonHangMaDH", "ChiTietDonHangMaSP");

                    b.Navigation("ChiTietDonHang");

                    b.Navigation("Kho");
                });

            modelBuilder.Entity("ECommerce.Models.ChiTietDonHang", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHang");
                });

            modelBuilder.Entity("ECommerce.Models.GiaoHang", b =>
                {
                    b.Navigation("DonHang");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("ECommerce.Models.HoaDon", b =>
                {
                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("ECommerce.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ECommerce.Models.Kho", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.KhuyenMai", b =>
                {
                    b.Navigation("DonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.Loai", b =>
                {
                    b.Navigation("Khos");
                });

            modelBuilder.Entity("ECommerce.Models.NhaCungCap", b =>
                {
                    b.Navigation("Khos");
                });

            modelBuilder.Entity("ECommerce.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ECommerce.Models.ThuongHieu", b =>
                {
                    b.Navigation("Khos");
                });
#pragma warning restore 612, 618
        }
    }
}
