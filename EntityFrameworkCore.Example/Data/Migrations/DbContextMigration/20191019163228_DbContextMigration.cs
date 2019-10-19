using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Example.Data.Migrations.DbContextMigration
{
    public partial class DbContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    DataId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => new { x.DataId, x.UserId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data");
        }
    }
}
