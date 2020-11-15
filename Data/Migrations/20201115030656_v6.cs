using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 6, 6, 55, 714, DateTimeKind.Local).AddTicks(4570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 15, 1, 56, 4, 900, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 6, 6, 55, 673, DateTimeKind.Local).AddTicks(6390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 15, 1, 56, 4, 864, DateTimeKind.Local).AddTicks(2620));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 1, 56, 4, 900, DateTimeKind.Local).AddTicks(5470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 15, 6, 6, 55, 714, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 1, 56, 4, 864, DateTimeKind.Local).AddTicks(2620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 15, 6, 6, 55, 673, DateTimeKind.Local).AddTicks(6390));
        }
    }
}
