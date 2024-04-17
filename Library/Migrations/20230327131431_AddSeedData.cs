using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "StudentDetail",
                newName: "BirthDay");

            migrationBuilder.AlterColumn<string>(
                name: "SchoolNumber",
                table: "StudentDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(8039), "Emirhan", 0, "Yeşil", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9180), "Safa", 0, "Başdemir", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9188), "Gürkan", 0, "Taş", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9190), "Zeynep", 1, "Kurt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 27, 16, 14, 30, 422, DateTimeKind.Local).AddTicks(689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$X/r0mrGoZdr9E4rp2HwztuAkt8qS5yRR..S9dNUfBi8k6opO5GB52", 1, 0, "administrator" },
                    { 2, new DateTime(2023, 3, 27, 16, 14, 30, 424, DateTimeKind.Local).AddTicks(4449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$Os0wetbH1qwcpacGfm/rOOvj5AWLtL.pimVNlxIE/qBG/8oZ4AkEK", 1, 0, "melike" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 16, 14, 30, 425, DateTimeKind.Local).AddTicks(9866), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 0, 1 },
                    { 2, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "101", 0, 2 },
                    { 3, new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "102", 0, 3 },
                    { 4, new DateTime(1990, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 16, 14, 30, 426, DateTimeKind.Local).AddTicks(855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "103", 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "StudentDetail",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolNumber",
                table: "StudentDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
