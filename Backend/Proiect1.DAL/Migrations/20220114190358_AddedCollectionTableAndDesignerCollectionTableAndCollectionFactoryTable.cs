using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect1.DAL.Migrations
{
    public partial class AddedCollectionTableAndDesignerCollectionTableAndCollectionFactoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumberOfItems = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CollectionFactories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    FactoryAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionFactories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectionFactories_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesignerCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignerId = table.Column<int>(type: "int", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignerCollections_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesignerCollections_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionFactories_CollectionId",
                table: "CollectionFactories",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerCollections_CollectionId",
                table: "DesignerCollections",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerCollections_DesignerId",
                table: "DesignerCollections",
                column: "DesignerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectionFactories");

            migrationBuilder.DropTable(
                name: "DesignerCollections");

            migrationBuilder.DropTable(
                name: "Collections");
        }
    }
}
