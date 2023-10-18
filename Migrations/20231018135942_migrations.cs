using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JorgeMoncayoL_EjercicioCF.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burguer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithCheese = table.Column<bool>(type: "bit", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burguer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoId = table.Column<int>(type: "int", nullable: false),
                    PromoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PromoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurguerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promo_Burguer_BurguerId",
                        column: x => x.BurguerId,
                        principalTable: "Burguer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurguerId",
                table: "Promo",
                column: "BurguerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");

            migrationBuilder.DropTable(
                name: "Burguer");
        }
    }
}
