using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class ImgContentFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(3055), new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ContentData", "CreatedDate", "ModifiedDate" },
                values: new object[] { "<img class=\"img-fluid\" src=\"/assets/images/databerrymigrationprocess.jpg\" alt=\"migration process\">", new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(792), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(9093), new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8427), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8421), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8414), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8408), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8401), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8395), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8388), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8382), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8376), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8369), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8363), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8356), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8350), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8344), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8337), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8331), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8324), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8318), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8312), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8305), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8299), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8292), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8257), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7698), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7691), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7684), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7678), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7671), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7665), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7659), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7652), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7646), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7639), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7633), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7626), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7618), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7553), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(5241), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4438), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4431), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4399), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(3882), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(2467), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(8310), new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(8262), new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(6366), new DateTime(2020, 6, 15, 20, 47, 23, 882, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 877, DateTimeKind.Local).AddTicks(6573), new DateTime(2020, 6, 15, 20, 47, 23, 880, DateTimeKind.Local).AddTicks(3243) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 69, DateTimeKind.Local).AddTicks(9102), new DateTime(2020, 6, 15, 14, 15, 42, 69, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ContentData", "CreatedDate", "ModifiedDate" },
                values: new object[] { "<img src=\\\"/images/databerrymigrationprocess.jpg\\\" alt=\\\"migration process\\\">", new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(7744), new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(3099), new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9465), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9447), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9430), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9413), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9395), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9377), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9359), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9341), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9324), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9307), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9289), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9271), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9253), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9235), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9210), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8909), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8890), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8871), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8853), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8835), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8817), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8797), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8702), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7106), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7088), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7052), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7035), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7018), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6998), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6980), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6962), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6945), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6926), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6907), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6885), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6718), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(391), new DateTime(2020, 6, 15, 14, 15, 42, 73, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(6621), new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(2569), new DateTime(2020, 6, 15, 14, 15, 42, 72, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(1015), new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(911), new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 70, DateTimeKind.Local).AddTicks(6379), new DateTime(2020, 6, 15, 14, 15, 42, 70, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 59, DateTimeKind.Local).AddTicks(9043), new DateTime(2020, 6, 15, 14, 15, 42, 65, DateTimeKind.Local).AddTicks(3599) });
        }
    }
}
