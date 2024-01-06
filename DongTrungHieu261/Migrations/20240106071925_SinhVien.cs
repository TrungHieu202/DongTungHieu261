using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DongTrungHieu261.Migrations
{
    /// <inheritdoc />
    public partial class SinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhVien_LopHoc_maLop",
                table: "SinhVien");

            migrationBuilder.DropColumn(
                name: "MaLop",
                table: "SinhVien");

            migrationBuilder.RenameColumn(
                name: "MaLop",
                table: "SinhVien",
                newName: "MaLop");

            migrationBuilder.RenameIndex(
                name: "IX_SinhVien_MaLop",
                table: "SinhVien",
                newName: "IX_SinhVien_MaLop");

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVien_LopHoc_MaLop",
                table: "SinhVien",
                column: "MaLop",
                principalTable: "LopHoc",
                principalColumn: "MaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhVien_LopHoc_MaLop",
                table: "SinhVien");

            migrationBuilder.RenameColumn(
                name: "MaLop",
                table: "SinhVien",
                newName: "MaLop");

            migrationBuilder.RenameIndex(
                name: "IX_SinhVien_MaLop",
                table: "SinhVien",
                newName: "IX_SinhVien_maLop");

            migrationBuilder.AddColumn<string>(
                name: "MaLop",
                table: "SinhVien",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVien_LopHoc_MaLop",
                table: "SinhVien",
                column: "MaLop",
                principalTable: "LopHoc",
                principalColumn: "MaLop");
        }
    }
}
