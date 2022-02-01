using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect1.DAL.Migrations
{
    public partial class AddedDesignerAddressTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesignerAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    DesignerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignerAddresses_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesignerAddresses_DesignerId",
                table: "DesignerAddresses",
                column: "DesignerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignerAddresses");
        }
    }
}
