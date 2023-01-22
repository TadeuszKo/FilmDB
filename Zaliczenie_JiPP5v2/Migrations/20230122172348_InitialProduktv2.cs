using Microsoft.EntityFrameworkCore.Migrations;

namespace Zaliczenie_JiPP5v2.Migrations
{
    public partial class InitialProduktv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KATEGORIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAZWA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ILOSC = table.Column<int>(type: "int", nullable: false),
                    JEDNOSTKA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_KUPNA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOKALIZACJA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkty");
        }
    }
}
