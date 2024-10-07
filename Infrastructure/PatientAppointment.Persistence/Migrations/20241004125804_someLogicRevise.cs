using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class someLogicRevise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Status_StatusId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Appointment",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                newName: "IX_Appointment_PatientId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LicenseExpirationDate",
                table: "Personnel",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Personnel",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AppointmentStatus",
                columns: table => new
                {
                    AppointmentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatus", x => x.AppointmentStatusId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AppointmentStatus_StatusId",
                table: "Appointment",
                column: "StatusId",
                principalTable: "AppointmentStatus",
                principalColumn: "AppointmentStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AppointmentStatus_StatusId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Appointment",
                newName: "PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointment",
                newName: "IX_Appointment_PatientID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LicenseExpirationDate",
                table: "Personnel",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Personnel",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientID",
                table: "Appointment",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Status_StatusId",
                table: "Appointment",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
