using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 850, DateTimeKind.Local).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 13, 41, 995, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 775, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 13, 41, 936, DateTimeKind.Local).AddTicks(1110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 13, 41, 995, DateTimeKind.Local).AddTicks(5940),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 850, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 13, 41, 936, DateTimeKind.Local).AddTicks(1110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 775, DateTimeKind.Local).AddTicks(8960));
        }
    }
}
