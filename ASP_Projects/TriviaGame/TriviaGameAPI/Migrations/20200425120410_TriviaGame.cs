using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaGameAPI.Migrations
{
    public partial class TriviaGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Role_Desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Role_code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_RoleMaster_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMaster",
                        column: x => x.FK_RoleMaster_Id,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_Users_FK_RoleMaster_Id",
                table: "Admin_Users",
                column: "FK_RoleMaster_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin_Users");

            migrationBuilder.DropTable(
                name: "RoleMaster");
        }
    }
}
