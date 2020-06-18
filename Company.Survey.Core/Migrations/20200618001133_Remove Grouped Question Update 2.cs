using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class RemoveGroupedQuestionUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyGroupQuestionsID",
                table: "SurveyQuestion");

            migrationBuilder.AddColumn<int>(
                name: "SurveyQuestionsID",
                table: "SurveyQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(2572), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 730, DateTimeKind.Local).AddTicks(5142), new DateTime(2020, 6, 17, 20, 11, 32, 730, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(5234), new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 733, DateTimeKind.Local).AddTicks(62), new DateTime(2020, 6, 17, 20, 11, 32, 733, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(2910), new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(407), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(402), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(396), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(390), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(378), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(372), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(366), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(360), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1257), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1259), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1252), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1254), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1246), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1249), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1241), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1243), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1236), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1238), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1230), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1233), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1225), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1227), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1220), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1222), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1214), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1217), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1209), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1211), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1204), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1206), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1198), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1201), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1193), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1195), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1187), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1190), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1182), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1185), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1177), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1179), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1172), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1174), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1169), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1150), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1161), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(414), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(416), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(354), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(348), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(342), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(335), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(329), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(322), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(315), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(309), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(300), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(293), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(286), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(279), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(258), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(7384), new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(1998), new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(1834), new DateTime(2020, 6, 17, 20, 11, 32, 731, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 730, DateTimeKind.Local).AddTicks(9406), new DateTime(2020, 6, 17, 20, 11, 32, 730, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 724, DateTimeKind.Local).AddTicks(9165), new DateTime(2020, 6, 17, 20, 11, 32, 728, DateTimeKind.Local).AddTicks(2675) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyQuestionsID",
                table: "SurveyQuestion");

            migrationBuilder.AddColumn<int>(
                name: "SurveyGroupQuestionsID",
                table: "SurveyQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(9630), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 194, DateTimeKind.Local).AddTicks(4878), new DateTime(2020, 6, 17, 20, 3, 18, 194, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(3602), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 196, DateTimeKind.Local).AddTicks(5023), new DateTime(2020, 6, 17, 20, 3, 18, 196, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(1155), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7898), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7893), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7887), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7882), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7877), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7872), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7866), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7861), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7856), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8637), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8640), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8632), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8634), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8627), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8629), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8621), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8623), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8616), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8618), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8611), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8613), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8605), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8608), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8600), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8602), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8595), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8597), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8589), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8592), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8584), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8586), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8578), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8581), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8573), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8575), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8566), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8569), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8506), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8508), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8500), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8503), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8495), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8498), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8490), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8492), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8474), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(8485), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyGroupQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7903), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7906), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7849), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7843), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7838), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7832), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7827), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7821), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7816), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7811), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7805), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7799), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7788), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7770), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(5371), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(216), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(198), new DateTime(2020, 6, 17, 20, 3, 18, 195, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 194, DateTimeKind.Local).AddTicks(8251), new DateTime(2020, 6, 17, 20, 3, 18, 194, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 3, 18, 189, DateTimeKind.Local).AddTicks(8367), new DateTime(2020, 6, 17, 20, 3, 18, 192, DateTimeKind.Local).AddTicks(6882) });
        }
    }
}
