using Microsoft.EntityFrameworkCore.Migrations;

namespace WebElectronicDocuments.Migrations.Wed
{
    public partial class Add_UserId_Column_DocJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DocJournals",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DocJournals");
        }
    }
}
