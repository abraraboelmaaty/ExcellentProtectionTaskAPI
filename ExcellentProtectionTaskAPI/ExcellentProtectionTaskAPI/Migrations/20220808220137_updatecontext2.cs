using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    public partial class updatecontext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 0, 1, 37, 656, DateTimeKind.Local).AddTicks(5500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 9, 0, 1, 37, 656, DateTimeKind.Local).AddTicks(7668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.AlterColumn<double>(
                name: "Paid",
                table: "Orders",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldComputedColumnSql: "dbo.getOrdersPaid([Id])");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(8922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 1, 37, 656, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 8, 23, 57, 20, 308, DateTimeKind.Local).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 9, 0, 1, 37, 656, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.AlterColumn<double>(
                name: "Paid",
                table: "Orders",
                type: "float",
                nullable: true,
                computedColumnSql: "dbo.getOrdersPaid([Id])",
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
