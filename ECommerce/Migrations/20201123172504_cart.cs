using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_ChiTietDonHangs_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                table: "SanPhams");

            migrationBuilder.DropIndex(
                name: "IX_SanPhams_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "ChiTietDonHangMaDH",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "ChiTietDonHangMaSP",
                table: "SanPhams");

            migrationBuilder.CreateTable(
                name: "productToCarts",
                columns: table => new
                {
                    SanPhamMaSP = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_productToCarts_SanPhams_SanPhamMaSP",
                        column: x => x.SanPhamMaSP,
                        principalTable: "SanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_MaSP",
                table: "ChiTietDonHangs",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_productToCarts_SanPhamMaSP",
                table: "productToCarts",
                column: "SanPhamMaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHangs_SanPhams_MaSP",
                table: "ChiTietDonHangs",
                column: "MaSP",
                principalTable: "SanPhams",
                principalColumn: "MaSP",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHangs_SanPhams_MaSP",
                table: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "productToCarts");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietDonHangs_MaSP",
                table: "ChiTietDonHangs");

            migrationBuilder.AddColumn<int>(
                name: "ChiTietDonHangMaDH",
                table: "SanPhams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChiTietDonHangMaSP",
                table: "SanPhams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                table: "SanPhams",
                columns: new[] { "ChiTietDonHangMaDH", "ChiTietDonHangMaSP" });

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_ChiTietDonHangs_ChiTietDonHangMaDH_ChiTietDonHangMaSP",
                table: "SanPhams",
                columns: new[] { "ChiTietDonHangMaDH", "ChiTietDonHangMaSP" },
                principalTable: "ChiTietDonHangs",
                principalColumns: new[] { "MaDH", "MaSP" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
