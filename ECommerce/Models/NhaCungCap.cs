using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class NhaCungCap
    {
        [Key]
        public int MaNhaCC { get; set; }
        public string TenNhaCC { get; set; }
        public string  DiaChi{ get; set; }
        public int MaSoThue { get; set; }
        public int Sdt { get; set; }
        public List<SanPham> sanPhams { get; set; }

    }
}
