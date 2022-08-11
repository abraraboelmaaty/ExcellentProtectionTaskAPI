using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    public partial class updatecontextandpayment1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(8922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.AddColumn<double>(
                name: "Paid",
                table: "Payments",
                type: "float",
                nullable: true,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Rest",
                table: "Payments",
                type: "float",
                nullable: true,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(1181));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Rest",
                table: "Payments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(1181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(9461));
        }
    }
}
