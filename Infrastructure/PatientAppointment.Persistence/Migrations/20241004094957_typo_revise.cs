using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class typo_revise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenDate",
                table: "Message",
                newName: "SendDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SendDate",
                table: "Message",
                newName: "SenDate");
        }
    }
}
