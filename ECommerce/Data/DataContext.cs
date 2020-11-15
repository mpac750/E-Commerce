using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;

namespace ECommerce.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>().HasKey(pk => new { pk.MaDH, pk.MaSP });
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs{ get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<GiaoHang> GiaoHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Kho> Khos { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
    }
}
