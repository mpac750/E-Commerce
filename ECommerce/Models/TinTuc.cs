using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class TinTuc
    {
        [Key]
        public int MaTT { get; set; }
        public int TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayDang { get; set; }
        public string HinhAnh { get; set; }
        public string Video { get; set; }
    }
}
