using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_AuthorId",
                schema: "dbo",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_AuthorId",
                schema: "dbo",
                table: "Post");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 750, DateTimeKind.Local).AddTicks(3560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 850, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 717, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 775, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "dbo",
                table: "Post",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                schema: "dbo",
                table: "Post",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_UserId",
                schema: "dbo",
                table: "Post",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_UserId",
                schema: "dbo",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_UserId",
                schema: "dbo",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "Post");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 850, DateTimeKind.Local).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 750, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 12, 23, 26, 40, 775, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 13, 18, 39, 44, 717, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.CreateIndex(
                name: "IX_Post_AuthorId",
                schema: "dbo",
                table: "Post",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_AuthorId",
                schema: "dbo",
                table: "Post",
                column: "AuthorId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
