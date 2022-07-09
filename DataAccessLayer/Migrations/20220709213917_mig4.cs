using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "BlogStatus",
                table: "Blogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BlogStatus",
                table: "Blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
