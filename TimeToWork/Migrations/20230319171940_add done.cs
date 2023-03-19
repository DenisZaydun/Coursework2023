using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeToWork.Migrations
{
    /// <inheritdoc />
    public partial class adddone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Done",
                columns: table => new
                {
                    DoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceProviderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Done", x => x.DoneId);
                    table.ForeignKey(
                        name: "FK_Done_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Done_ServiceProvider_ServiceProviderID",
                        column: x => x.ServiceProviderID,
                        principalTable: "ServiceProvider",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Done_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Done_ClientId",
                table: "Done",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Done_ServiceId",
                table: "Done",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Done_ServiceProviderID",
                table: "Done",
                column: "ServiceProviderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Done");
        }
    }
}
