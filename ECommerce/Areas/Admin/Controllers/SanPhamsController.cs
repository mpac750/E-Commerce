using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamsController : Controller
    {
        private readonly DataContext _context;

        public SanPhamsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/SanPhams
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.SanPhams.Include(s => s.Loai).Include(s => s.NhaCungCap).Include(s => s.ThuongHieu);
            return View(await dataContext.ToListAsync());
        }

        // GET: Admin/SanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.Loai)
                .Include(s => s.NhaCungCap)
                .Include(s => s.ThuongHieu)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: Admin/SanPhams/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.Loais, "MaLoai", "TenLoai");
            ViewData["MaNhaCC"] = new SelectList(_context.NhaCungCaps, "MaNhaCC", "TenNhaCC");
            ViewData["MaTH"] = new SelectList(_context.ThuongHieus, "MaTH", "TenTH");
            return View();
        }

        // POST: Admin/SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSP,TenSP,DonGia,HinhAnh,Video,ChiTietSP,SoLuong,SoLuongMuaToiThieu,MaLoai,MaTH,MaNhaCC")] SanPham sanPham,IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                if (photo == null || photo.Length == 0)
                {
                    sanPham.HinhAnh = "iphone12.jpg";
                }

                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    _ = photo.CopyToAsync(stream);
                    sanPham.HinhAnh = photo.FileName;
                }
                ViewData["MaLoai"] = new SelectList(_context.Loais, "MaLoai", "MaLoai", sanPham.MaLoai);
                ViewData["MaNhaCC"] = new SelectList(_context.NhaCungCaps, "MaNhaCC", "MaNhaCC", sanPham.MaNhaCC);
                ViewData["MaTH"] = new SelectList(_context.ThuongHieus, "MaTH", "MaTH", sanPham.MaTH);
                _context.Add(sanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else 
            return View(sanPham);
        }

        // GET: Admin/SanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.Loais, "MaLoai", "TenLoai", sanPham.MaLoai);
            ViewData["MaNhaCC"] = new SelectList(_context.NhaCungCaps, "MaNhaCC", "TenNhaCC", sanPham.MaNhaCC);
            ViewData["MaTH"] = new SelectList(_context.ThuongHieus, "MaTH", "TenTH", sanPham.MaTH);
            return View(sanPham);
        }

        // POST: Admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSP,TenSP,DonGia,HinhAnh,Video,ChiTietSP,SoLuong,SoLuongMuaToiThieu,MaLoai,MaTH,MaNhaCC")] SanPham sanPham)
        {
            if (id != sanPham.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.MaSP))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.Loais, "MaLoai", "MaLoai", sanPham.MaLoai);
            ViewData["MaNhaCC"] = new SelectList(_context.NhaCungCaps, "MaNhaCC", "MaNhaCC", sanPham.MaNhaCC);
            ViewData["MaTH"] = new SelectList(_context.ThuongHieus, "MaTH", "MaTH", sanPham.MaTH);
            return View(sanPham);
        }

        // GET: Admin/SanPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.Loai)
                .Include(s => s.NhaCungCap)
                .Include(s => s.ThuongHieu)
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: Admin/SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPham = await _context.SanPhams.FindAsync(id);
            _context.SanPhams.Remove(sanPham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPhams.Any(e => e.MaSP == id);
        }
    }
}
