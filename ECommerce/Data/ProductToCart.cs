using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class ProductToCart
    {
        public SanPham SanPham{ get; set; }
        public int Quantity { get; set; }
    }
}
