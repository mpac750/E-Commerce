using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public List<SanPham> sanPhams { get; set; }
    }
}
