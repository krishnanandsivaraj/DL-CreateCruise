using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamLines.Infrastructure.Migrations
{
    public partial class DreamLines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cabinTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nid = table.Column<int>(nullable: false),
                    ship_id = table.Column<int>(nullable: false),
                    company_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cabinTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cruise",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nid = table.Column<int>(nullable: false),
                    shipId = table.Column<int>(nullable: false),
                    cabinType = table.Column<int>(nullable: false),
                    rId = table.Column<int>(nullable: false),
                    departureDate = table.Column<DateTime>(nullable: false),
                    isFlight = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cruise", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cruiseLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nid = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cruiseLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ports",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nid = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ships",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ship_id = table.Column<int>(nullable: false),
                    company_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ships", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cabinTypes");

            migrationBuilder.DropTable(
                name: "cruise");

            migrationBuilder.DropTable(
                name: "cruiseLines");

            migrationBuilder.DropTable(
                name: "ports");

            migrationBuilder.DropTable(
                name: "ships");
        }
    }
}
