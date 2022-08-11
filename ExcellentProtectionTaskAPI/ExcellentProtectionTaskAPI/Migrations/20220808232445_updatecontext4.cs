using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    public partial class updatecontext4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 1, 24, 45, 266, DateTimeKind.Local).AddTicks(9394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 1, 23, 22, 468, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 9, 1, 24, 45, 266, DateTimeKind.Local).AddTicks(9775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 9, 1, 23, 22, 468, DateTimeKind.Local).AddTicks(9196));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 1, 23, 22, 468, DateTimeKind.Local).AddTicks(8846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 1, 24, 45, 266, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 9, 1, 23, 22, 468, DateTimeKind.Local).AddTicks(9196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 9, 1, 24, 45, 266, DateTimeKind.Local).AddTicks(9775));

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
    }
}
