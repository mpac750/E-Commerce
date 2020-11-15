using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }
        public int MaDH { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int Sdt { get; set; }
        public List<DonHang> DonHang { get; set; }
        public KhachHang KhachHang { get; set; }
        public GiaoHang GiaoHang { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
