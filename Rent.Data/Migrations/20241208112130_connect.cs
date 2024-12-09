using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rent.Data.Migrations
{
    /// <inheritdoc />
    public partial class connect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Turns",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartHour",
                table: "Turns",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EndHour",
                table: "Turns",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateStart",
                table: "Turns",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateEnd",
                table: "Turns",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Turns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turns_ClinicId",
                table: "Turns",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Turns_TenantId",
                table: "Turns",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Tenants_TenantId",
                table: "Turns",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Clinics_ClinicId",
                table: "Turns");

            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Tenants_TenantId",
                table: "Turns");

            migrationBuilder.DropIndex(
                name: "IX_Turns_ClinicId",
                table: "Turns");

            migrationBuilder.DropIndex(
                name: "IX_Turns_TenantId",
                table: "Turns");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Turns");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Turns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartHour",
                table: "Turns",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndHour",
                table: "Turns",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateStart",
                table: "Turns",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Turns",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
