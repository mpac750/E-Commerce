using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class KhuyenMai
    {
        [Key]
        public string MaKM { get; set; }
        public string ChitietKhuyenMai { get; set; }
        public string DieuKienApDung { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<DonHang> DonHangs { get; set; }
    }
}
