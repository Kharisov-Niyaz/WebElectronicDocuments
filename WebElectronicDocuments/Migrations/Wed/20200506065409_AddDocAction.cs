using Microsoft.EntityFrameworkCore.Migrations;

namespace WebElectronicDocuments.Migrations.Wed
{
    public partial class AddDocAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocId = table.Column<int>(nullable: false),
                    NormalInspectionId = table.Column<int>(nullable: false),
                    StageId = table.Column<int>(nullable: false),
                    Urgency = table.Column<bool>(nullable: false),
                    Update = table.Column<bool>(nullable: false),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocActions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocActions");
        }
    }
}
