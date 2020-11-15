using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int DonGia { get; set; }
        public string HinhAnh { get; set; }
        public string Video { get; set; }
        public string ChiTietSP { get; set; }
        public int SoLuong{ get; set; }
        public int SoLuongMuaToiThieu { get; set; }
        public Kho Kho { get; set; }
        public ChiTietDonHang ChiTietDonHang { get; set; }
    
    }
}
