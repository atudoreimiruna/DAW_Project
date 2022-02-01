using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect1.DAL.Migrations
{
    public partial class AddedDesignerAwardTableAndClientTableAndDesignerClientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignerAwards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Contest = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DesignerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerAwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignerAwards_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesignerClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignerId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignerClients_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesignerClients_Designers_DesignerId",
                        column: x => x.DesignerId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesignerAwards_DesignerId",
                table: "DesignerAwards",
                column: "DesignerId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerClients_ClientId",
                table: "DesignerClients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerClients_DesignerId",
                table: "DesignerClients",
                column: "DesignerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignerAwards");

            migrationBuilder.DropTable(
                name: "DesignerClients");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
