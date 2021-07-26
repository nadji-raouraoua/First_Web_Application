using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seance",
                columns: table => new
                {
                    IDGymnase = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSport = table.Column<int>(type: "int", nullable: false),
                    Jour = table.Column<int>(type: "int", nullable: false),
                    Horaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duree = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seance", x => x.IDGymnase);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seance");
        }
    }
}
