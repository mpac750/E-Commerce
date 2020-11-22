using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ThuongHieu
    {
        [Key]
        public int MaTH { get; set; }
        public string TenTH { get; set; }
        public string Mota { get; set; }
        public List<SanPham> sanPhams { get; set; }
    }
}
