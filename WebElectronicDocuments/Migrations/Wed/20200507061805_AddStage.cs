using Microsoft.EntityFrameworkCore.Migrations;

namespace WebElectronicDocuments.Migrations.Wed
{
    public partial class AddStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "blue", "Исполнитель" },
                    { 2, "orange", "Нормоконтроль" },
                    { 3, "brown", "Директор" },
                    { 4, "green", "СМК" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stages");
        }
    }
}
