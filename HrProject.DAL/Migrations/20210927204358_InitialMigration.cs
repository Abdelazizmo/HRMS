using Microsoft.EntityFrameworkCore.Migrations;

namespace HrProject.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    NameArbic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsCreationPlace = table.Column<bool>(type: "bit", nullable: false),
                    IsCreationDate = table.Column<bool>(type: "bit", nullable: false),
                    IsExpiredDate = table.Column<bool>(type: "bit", nullable: false),
                    IsRenewableDate = table.Column<bool>(type: "bit", nullable: false),
                    IsRenwableValue = table.Column<bool>(type: "bit", nullable: false),
                    IsRepeated = table.Column<bool>(type: "bit", nullable: false),
                    IsHasAttatchment = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardsType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardsType");
        }
    }
}
