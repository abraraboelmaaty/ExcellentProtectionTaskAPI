using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    public partial class updatepayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Paid",
                table: "Payments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 0, 10, 56, 312, DateTimeKind.Local).AddTicks(9508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 2, 22, 314, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.AlterColumn<double>(
                name: "Ammount",
                table: "Payments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 9, 0, 10, 56, 312, DateTimeKind.Local).AddTicks(9985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 2, 22, 314, DateTimeKind.Local).AddTicks(9931));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Paid",
                table: "Payments",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 0, 2, 22, 314, DateTimeKind.Local).AddTicks(9146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 10, 56, 312, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.AlterColumn<double>(
                name: "Ammount",
                table: "Payments",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 9, 0, 2, 22, 314, DateTimeKind.Local).AddTicks(9931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 10, 56, 312, DateTimeKind.Local).AddTicks(9985));
        }
    }
}
