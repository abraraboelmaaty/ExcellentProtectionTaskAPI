using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellentProtectionTaskAPI.Migrations
{
    public partial class updateorderandcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(1181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.AlterColumn<double>(
                name: "Rest",
                table: "Orders",
                type: "float",
                nullable: true,
                computedColumnSql: "dbo.getRest([Id])",
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Paid",
                table: "Orders",
                type: "float",
                nullable: true,
                computedColumnSql: "dbo.getOrdersPaid([Id])",
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "dbo.getOrderStatus([Id])");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(7572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OrdersPayment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 8, 1, 42, 10, 9, DateTimeKind.Local).AddTicks(8171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 8, 1, 44, 48, 616, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.AlterColumn<double>(
                name: "Rest",
                table: "Orders",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldComputedColumnSql: "dbo.getRest([Id])");

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
