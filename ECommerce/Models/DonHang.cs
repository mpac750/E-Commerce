using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; }
        public DateTime NgayTaoDH { get; set; }
        public string GhiChuDH { get; set; }
        public string TenKH { get; set; }
        public string DiaChiNhan { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string TinhtrangDH { get; set; }
        public string MaKM { get; set; }
    }
}
