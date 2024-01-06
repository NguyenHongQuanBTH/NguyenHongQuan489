using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenHongQuan489.Migrations
{
    /// <inheritdoc />
    public partial class Table_Personss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personss",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "TEXT", nullable: false),
                    TenNV = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personss", x => x.MaNV);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personss");
        }
    }
}
