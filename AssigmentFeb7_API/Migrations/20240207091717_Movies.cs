using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssigmentFeb7_API.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    starCast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleasingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
