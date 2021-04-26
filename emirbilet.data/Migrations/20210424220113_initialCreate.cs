using Microsoft.EntityFrameworkCore.Migrations;

namespace emirbilet.data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guzergahs",
                columns: table => new
                {
                    GuzergahId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<string>(nullable: true),
                    gz1 = table.Column<string>(nullable: true),
                    gz2 = table.Column<string>(nullable: true),
                    gz3 = table.Column<string>(nullable: true),
                    Bitis = table.Column<string>(nullable: true),
                    Tarih = table.Column<string>(nullable: true),
                    Saat = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Fiyat = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guzergahs", x => x.GuzergahId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SehirAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Nereden = table.Column<string>(nullable: true),
                    Nereye = table.Column<string>(nullable: true),
                    KoltukNo = table.Column<int>(nullable: false),
                    Fiyat = table.Column<double>(nullable: false),
                    GuzergahId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletId);
                    table.ForeignKey(
                        name: "FK_Bilets_Guzergahs_GuzergahId",
                        column: x => x.GuzergahId,
                        principalTable: "Guzergahs",
                        principalColumn: "GuzergahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_GuzergahId",
                table: "Bilets",
                column: "GuzergahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Guzergahs");
        }
    }
}
