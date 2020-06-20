using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class Addcompositeuniqueconstraintonsurveykeyandversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurveyKey",
                table: "Surveys",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(236), new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(6143), new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(4108), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(4357), new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(2392), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8484), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8478), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8472), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8466), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8461), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8456), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8451), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8445), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8439), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9234), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9228), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9223), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9218), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9212), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9207), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9202), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9195), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9189), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9184), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9178), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9162), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9157), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9151), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9141), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9125), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8546), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8434), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8428), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8423), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8418), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8412), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8407), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8401), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8394), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8389), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8383), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8378), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8371), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1567), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1549), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(9559), new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 736, DateTimeKind.Local).AddTicks(1334), new DateTime(2020, 6, 18, 16, 35, 2, 738, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_SurveyKey_Version",
                table: "Surveys",
                columns: new[] { "SurveyKey", "Version" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Surveys_SurveyKey_Version",
                table: "Surveys");

            migrationBuilder.AlterColumn<string>(
                name: "SurveyKey",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 733, DateTimeKind.Local).AddTicks(316), new DateTime(2020, 6, 18, 16, 26, 37, 733, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 731, DateTimeKind.Local).AddTicks(5529), new DateTime(2020, 6, 18, 16, 26, 37, 731, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(4025), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 733, DateTimeKind.Local).AddTicks(4345), new DateTime(2020, 6, 18, 16, 26, 37, 733, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(2136), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8519), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8513), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8508), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8502), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8497), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8491), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8486), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8480), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8475), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9272), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9266), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9260), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9254), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9249), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9243), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9238), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9232), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9226), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9220), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9215), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9209), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9204), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9198), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9192), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9186), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9180), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9104), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8524), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8468), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8462), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8457), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8450), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8444), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8438), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8432), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8426), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8415), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8409), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8401), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8385), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(5783), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(1286), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(1268), new DateTime(2020, 6, 18, 16, 26, 37, 732, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 731, DateTimeKind.Local).AddTicks(9221), new DateTime(2020, 6, 18, 16, 26, 37, 731, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 725, DateTimeKind.Local).AddTicks(4950), new DateTime(2020, 6, 18, 16, 26, 37, 729, DateTimeKind.Local).AddTicks(5139) });
        }
    }
}
