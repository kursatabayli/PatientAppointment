using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Clinic_to_Polyclinic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Clinic_PolyclinicId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Clinic_PolyclinicId",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinic",
                table: "Clinic");

            migrationBuilder.RenameTable(
                name: "Clinic",
                newName: "Polyclinic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Polyclinic",
                table: "Polyclinic",
                column: "PolyclinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Polyclinic_PolyclinicId",
                table: "Appointment",
                column: "PolyclinicId",
                principalTable: "Polyclinic",
                principalColumn: "PolyclinicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Polyclinic_PolyclinicId",
                table: "Personnel",
                column: "PolyclinicId",
                principalTable: "Polyclinic",
                principalColumn: "PolyclinicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Polyclinic_PolyclinicId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Polyclinic_PolyclinicId",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Polyclinic",
                table: "Polyclinic");

            migrationBuilder.RenameTable(
                name: "Polyclinic",
                newName: "Clinic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinic",
                table: "Clinic",
                column: "PolyclinicId");

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
    }
}
