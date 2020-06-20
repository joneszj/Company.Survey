using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class Addkeytodifferentiatesurveyversions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyKey",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate", "SurveyKey", "Title" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 26, 37, 725, DateTimeKind.Local).AddTicks(4950), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 18, 16, 26, 37, 729, DateTimeKind.Local).AddTicks(5139), "Infrastructure Migration", "Infrastructure Migration Survey Form" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyKey",
                table: "Surveys");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(3239), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 210, DateTimeKind.Local).AddTicks(9211), new DateTime(2020, 6, 17, 23, 22, 28, 210, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(7143), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(7225), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(5398), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1542), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1532), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1526), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1521), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1516), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1511), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1505), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1500), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2232), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2222), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2217), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2211), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2206), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2201), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2195), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2190), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2184), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2179), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2173), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2168), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2163), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2157), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2150), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2145), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2140), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1547), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1495), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1489), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1484), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1479), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1474), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1468), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1462), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1457), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1451), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1445), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1438), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1380), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1363), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(8934), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(4599), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(4582), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(2603), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 206, DateTimeKind.Local).AddTicks(1750), new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 17, 23, 22, 28, 209, DateTimeKind.Local).AddTicks(848), "Infrastructure Migration Survey Form V8" });
        }
    }
}
