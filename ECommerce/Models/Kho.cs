using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Kho
    {
        [Key]
        public int MaSP{ get; set; }
        public string TenSP { get; set; }
        public int DonGiaNhap { get; set; }
        public int SoLuongNhap{ get; set; }
        public int MaLoai { get; set; }
        public int MaTH { get; set; }
        public int MaNhaCC { get; set; }
        public List<SanPham> SanPhams { get; set; }
        public Loai Loai { get; set; }
        public ThuongHieu ThuongHieu { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
    }
}
