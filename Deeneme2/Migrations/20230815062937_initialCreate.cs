using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deeneme2.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TravelEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelForms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelForms");
        }
    }
}
