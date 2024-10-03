using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class some_revise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Clinic_ClinicId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Clinic_ClinicId",
                table: "Personnel");

            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Personnel",
                newName: "PolyclinicId");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_ClinicId",
                table: "Personnel",
                newName: "IX_Personnel_PolyclinicId");

            migrationBuilder.RenameColumn(
                name: "ClinicName",
                table: "Clinic",
                newName: "PolyclinicName");

            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Clinic",
                newName: "PolyclinicId");

            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Appointment",
                newName: "PolyclinicId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ClinicId",
                table: "Appointment",
                newName: "IX_Appointment_PolyclinicId");

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "Personnel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Clinic_PolyclinicId",
                table: "Appointment",
                column: "PolyclinicId",
                principalTable: "Clinic",
                principalColumn: "PolyclinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Clinic_PolyclinicId",
                table: "Personnel",
                column: "PolyclinicId",
                principalTable: "Clinic",
                principalColumn: "PolyclinicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Clinic_PolyclinicId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Clinic_PolyclinicId",
                table: "Personnel");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "Personnel");

            migrationBuilder.RenameColumn(
                name: "PolyclinicId",
                table: "Personnel",
                newName: "ClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_PolyclinicId",
                table: "Personnel",
                newName: "IX_Personnel_ClinicId");

            migrationBuilder.RenameColumn(
                name: "PolyclinicName",
                table: "Clinic",
                newName: "ClinicName");

            migrationBuilder.RenameColumn(
                name: "PolyclinicId",
                table: "Clinic",
                newName: "ClinicId");

            migrationBuilder.RenameColumn(
                name: "PolyclinicId",
                table: "Appointment",
                newName: "ClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PolyclinicId",
                table: "Appointment",
                newName: "IX_Appointment_ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Clinic_ClinicId",
                table: "Appointment",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "ClinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Clinic_ClinicId",
                table: "Personnel",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "ClinicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
