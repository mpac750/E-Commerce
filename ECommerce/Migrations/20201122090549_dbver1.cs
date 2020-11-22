using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class dbver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaoHangs",
                columns: table => new
                {
                    MaGH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    NgayGiaoHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tinhtrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoHangs", x => x.MaGH);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemKH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaTK);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChitietKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DieuKienApDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    MaNhaCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSoThue = table.Column<int>(type: "int", nullable: false),
                    Sdt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.MaNhaCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNV = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayNhanViec = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaTK);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    MaTH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.MaTH);
                });

            migrationBuilder.CreateTable(
                name: "TinTucs",
                columns: table => new
                {
                    MaTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTucs", x => x.MaTT);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    KhachHangMaTK = table.Column<int>(type: "int", nullable: true),
                    GiaoHangMaGH = table.Column<int>(type: "int", nullable: true),
                    NhanVienMaTK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDons_GiaoHangs_GiaoHangMaGH",
                        column: x => x.GiaoHangMaGH,
                        principalTable: "GiaoHangs",
                        principalColumn: "MaGH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangMaTK",
                        column: x => x.KhachHangMaTK,
                        principalTable: "KhachHangs",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_NhanVienMaTK",
                        column: x => x.NhanVienMaTK,
                        principalTable: "NhanViens",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTaoDH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuDH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhtrangDH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoaDonMaHD = table.Column<int>(type: "int", nullable: true),
                    GiaoHangMaGH = table.Column<int>(type: "int", nullable: true),
                    KhuyenMaiMaKM = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.MaDH);
                    table.ForeignKey(
                        name: "FK_DonHangs_GiaoHangs_GiaoHangMaGH",
                        column: x => x.GiaoHangMaGH,
                        principalTable: "GiaoHangs",
                        principalColumn: "MaGH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangs_HoaDons_HoaDonMaHD",
                        column: x => x.HoaDonMaHD,
                        principalTable: "HoaDons",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangs_KhuyenMais_KhuyenMaiMaKM",
                        column: x => x.KhuyenMaiMaKM,
                        principalTable: "KhuyenMais",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuongSP = table.Column<int>(type: "int", nullable: false),
                    SotienSP = table.Column<int>(type: "int", nullable: false),
                    TongTienDH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => new { x.MaDH, x.MaSP });
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_DonHangs_MaDH",
                        column: x => x.MaDH,
                        principalTable: "DonHangs",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiTietSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    SoLuongMuaToiThieu = table.Column<int>(type: "int", nullable: false),
                    ChiTietDonHangMaDH = table.Column<int>(type: "int", nullable: true),
                    ChiTietDonHangMaSP = table.Column<int>(type: "int", nullable: true),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    MaTH = table.Column<int>(type: "int", nullable: false),
                    MaNhaCC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPhams_ChiTietDonHangs_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                        columns: x => new { x.ChiTietDonHangMaDH, x.ChiTietDonHangMaSP },
                        principalTable: "ChiTietDonHangs",
                        principalColumns: new[] { "MaDH", "MaSP" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhams_Loais_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "Loais",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhams_NhaCungCaps_MaNhaCC",
                        column: x => x.MaNhaCC,
                        principalTable: "NhaCungCaps",
                        principalColumn: "MaNhaCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhams_ThuongHieus_MaTH",
                        column: x => x.MaTH,
                        principalTable: "ThuongHieus",
                        principalColumn: "MaTH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_GiaoHangMaGH",
                table: "DonHangs",
                column: "GiaoHangMaGH");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_HoaDonMaHD",
                table: "DonHangs",
                column: "HoaDonMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_KhuyenMaiMaKM",
                table: "DonHangs",
                column: "KhuyenMaiMaKM");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_GiaoHangMaGH",
                table: "HoaDons",
                column: "GiaoHangMaGH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangMaTK",
                table: "HoaDons",
                column: "KhachHangMaTK");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienMaTK",
                table: "HoaDons",
                column: "NhanVienMaTK");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                table: "SanPhams",
                columns: new[] { "ChiTietDonHangMaDH", "ChiTietDonHangMaSP" });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaLoai",
                table: "SanPhams",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaNhaCC",
                table: "SanPhams",
                column: "MaNhaCC");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaTH",
                table: "SanPhams",
                column: "MaTH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TinTucs");

            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "GiaoHangs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
