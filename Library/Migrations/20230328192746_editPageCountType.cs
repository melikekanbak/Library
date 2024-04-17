using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class editPageCountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageCount",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 28, 22, 27, 46, 419, DateTimeKind.Local).AddTicks(9418), "$2a$11$erv.382lHr9cUfynnH1Jme1X9E.7saa.FiGftywX3Ja/CmMw/NQxm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 28, 22, 27, 46, 424, DateTimeKind.Local).AddTicks(4715), "$2a$11$sjl2/JQYQsdzLCBOb97BXOvRo6No89Ixn6YWBQYp/zJVXP4DPl9Da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PageCount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 22, 54, 59, 974, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 22, 54, 59, 972, DateTimeKind.Local).AddTicks(4231), "$2a$11$fHM40DD7a83Pk7YPL/ama.Ks/AiN1B6NjtH7chzqSSy.ALaTBNPqu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 22, 54, 59, 973, DateTimeKind.Local).AddTicks(5089), "$2a$11$Rq.HhjIhfTEmPtaQFNuTheijp20BTDf1TaDT3jK66KayH97WcPWz." });
        }
    }
}
