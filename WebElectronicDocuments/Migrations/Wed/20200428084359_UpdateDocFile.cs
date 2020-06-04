using Microsoft.EntityFrameworkCore.Migrations;

namespace WebElectronicDocuments.Migrations.Wed
{
    public partial class UpdateDocFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocId",
                table: "DocFiles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocId",
                table: "DocFiles");
        }
    }
}
