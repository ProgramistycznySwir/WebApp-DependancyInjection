using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_DependancyInjection.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    maker = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    img = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    url = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    title = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
