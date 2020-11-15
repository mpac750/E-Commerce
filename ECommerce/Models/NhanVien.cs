using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class NhanVien
    {
        [Key]
        public int MaTK { get; set; }
        public int TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int Sdt { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime NgayNhanViec { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
}
