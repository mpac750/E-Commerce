﻿using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using ECommerce.Areas.Users.Helper;
using ECommerce.Data;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace ECommerce.Areas.Users.Controllers
{
    [Area("Users")]
    public class CartController : Controller
    {
        private readonly DataContext _context;
        public CartController(DataContext _context)
        {
            this._context = _context;

        }
        public IActionResult Null()
        {
            return View();
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.SanPham.DonGia * item.Quantity);


            return View();
        }
        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                cart.Add(new ProductToCart
                {
                    SanPham = _context.SanPhams.FirstOrDefault(p => p.MaSP == id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductToCart
                    {
                        SanPham = _context.SanPhams.FirstOrDefault(p => p.MaSP == id),
                        Quantity = 1
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }



        [Route("remove/{id}")]

        public IActionResult Remove(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].SanPham.MaSP == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Checkout()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(string shipName, string mobile, string address, string email, string ghichu)
        {
            var order = new DonHang();
            order.NgayTaoDH = DateTime.Now;
            order.DiaChiNhan = address;
            order.SoDienThoai = mobile;
            order.TenKH = shipName;
            order.Email = email;
            order.GhiChuDH = ghichu;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("alicet8436.01@gmail.com"));
            message.To.Add(new MailboxAddress(email));
            message.Subject = "Dat hang thanh cong";
            message.Body = new TextPart("plain")
            {
                Text = "Dat hang thanh cong" + "---------------" + shipName + "- " + address + "-"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("alicet8436.01@gmail.com", "Bunnyneit8436");
                client.Send(message);
                client.Disconnect(true);
            }
            return Redirect("/Users/Cart/Success");
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}

