using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeToWork.Migrations
{
    /// <inheritdoc />
    public partial class efssdjm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ServiceProvider_ServiceProviderId",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderId",
                table: "Appointment",
                newName: "ServiceProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ServiceProviderId",
                table: "Appointment",
                newName: "IX_Appointment_ServiceProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ServiceProvider_ServiceProviderID",
                table: "Appointment",
                column: "ServiceProviderID",
                principalTable: "ServiceProvider",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ServiceProvider_ServiceProviderID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderID",
                table: "Appointment",
                newName: "ServiceProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ServiceProviderID",
                table: "Appointment",
                newName: "IX_Appointment_ServiceProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ServiceProvider_ServiceProviderId",
                table: "Appointment",
                column: "ServiceProviderId",
                principalTable: "ServiceProvider",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
