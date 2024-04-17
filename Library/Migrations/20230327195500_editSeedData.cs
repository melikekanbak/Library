using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class editSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Password", "Role" },
                values: new object[] { new DateTime(2023, 3, 27, 22, 54, 59, 973, DateTimeKind.Local).AddTicks(5089), "$2a$11$Rq.HhjIhfTEmPtaQFNuTheijp20BTDf1TaDT3jK66KayH97WcPWz.", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 16, 14, 30, 422, DateTimeKind.Local).AddTicks(689), "$2a$11$X/r0mrGoZdr9E4rp2HwztuAkt8qS5yRR..S9dNUfBi8k6opO5GB52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "Role" },
                values: new object[] { new DateTime(2023, 3, 27, 16, 14, 30, 424, DateTimeKind.Local).AddTicks(4449), "$2a$11$Os0wetbH1qwcpacGfm/rOOvj5AWLtL.pimVNlxIE/qBG/8oZ4AkEK", 1 });
        }
    }
}
