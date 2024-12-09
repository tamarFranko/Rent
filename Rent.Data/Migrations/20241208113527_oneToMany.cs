using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rent.Data.Migrations
{
    /// <inheritdoc />
    public partial class oneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns");

            migrationBuilder.DropColumn(
                name: "ClinicName",
                table: "Turns");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Turns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Turns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ClinicName",
                table: "Turns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");
        }
    }
}
