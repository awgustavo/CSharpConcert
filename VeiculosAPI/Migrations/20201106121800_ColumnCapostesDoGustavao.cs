using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiculosAPI.Migrations
{
    public partial class ColumnCapostesDoGustavao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CapostesDoGustavao",
                table: "Moto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapostesDoGustavao",
                table: "Moto");
        }
    }
}
