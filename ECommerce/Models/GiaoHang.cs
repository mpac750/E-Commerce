using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class GiaoHang
    {
        [Key]
        public int MaGH { get; set; }
        public int MaDH{ get; set; }
        public int MaHD { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public string Tinhtrang { get; set; }
        public string GhiChu { get; set; }
        public List<HoaDon> HoaDon { get; set; }
        public List<DonHang> DonHang { get; set; }
    }
}
