﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer4_Base.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CustomUsers",
                columns: new[] { "Id", "City", "Email", "Password", "UserName" },
                values: new object[] { 1, "Saatli", "rahib@gmail.com", "password", "rahibjafar" });

            migrationBuilder.InsertData(
                table: "CustomUsers",
                columns: new[] { "Id", "City", "Email", "Password", "UserName" },
                values: new object[] { 2, "Baku", "test@gmail.com", "password", "test" });

            migrationBuilder.InsertData(
                table: "CustomUsers",
                columns: new[] { "Id", "City", "Email", "Password", "UserName" },
                values: new object[] { 3, "Quba", "testuser@gmail.com", "password", "testuser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomUsers");
        }
    }
}
