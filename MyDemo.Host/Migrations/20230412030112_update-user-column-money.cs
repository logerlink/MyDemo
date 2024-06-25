using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDemo.Host.Migrations
{
    public partial class updateusercolumnmoney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Money",
                table: "Users",
                type: "decimal(16,5)",
                precision: 16,
                scale: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<decimal>(
                name: "Address_Price",
                table: "Users",
                type: "decimal(16,5)",
                precision: 16,
                scale: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_Price",
                table: "Users");

            migrationBuilder.AlterColumn<decimal>(
                name: "Money",
                table: "Users",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,5)",
                oldPrecision: 16,
                oldScale: 5);
        }
    }
}
