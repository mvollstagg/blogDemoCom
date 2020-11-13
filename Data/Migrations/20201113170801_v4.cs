using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 20, 8, 0, 595, DateTimeKind.Local).AddTicks(2500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 750, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 20, 8, 0, 524, DateTimeKind.Local).AddTicks(760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 717, DateTimeKind.Local).AddTicks(460));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 750, DateTimeKind.Local).AddTicks(3560),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 13, 20, 8, 0, 595, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 717, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 13, 20, 8, 0, 524, DateTimeKind.Local).AddTicks(760));
        }
    }
}
