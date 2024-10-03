using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class relation_with_Personnel_and_Appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonnelId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PersonnelId",
                table: "Appointment",
                column: "PersonnelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Personnel_PersonnelId",
                table: "Appointment",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Personnel_PersonnelId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_PersonnelId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "PersonnelId",
                table: "Appointment");
        }
    }
}
