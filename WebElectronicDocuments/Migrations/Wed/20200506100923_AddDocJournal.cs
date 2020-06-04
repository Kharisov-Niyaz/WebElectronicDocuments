using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebElectronicDocuments.Migrations.Wed
{
    public partial class AddDocJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocJournals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(nullable: true),
                    EventType = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DocId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocJournals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocJournals");
        }
    }
}
