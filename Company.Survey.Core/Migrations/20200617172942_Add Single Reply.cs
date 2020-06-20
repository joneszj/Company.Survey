using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddSingleReply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(3599), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(115), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(1324), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "ClientSurveyId", "CreatedBy", "CreatedDate", "GroupIndex", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[] { -1, -1, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(9081), null, true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(9101), "Azure", -1 });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(8868), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2225), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2216), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2208), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2201), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2192), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2183), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2173), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2166), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2158), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2151), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2144), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2136), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2129), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2122), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2114), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2107), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2100), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2092), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2084), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2006), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1999), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1971), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1190), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1181), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1174), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1159), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1151), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1144), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1137), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1130), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1122), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1115), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1107), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1097), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1074), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(7711), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6435), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6426), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6406), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(5715), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(3722), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7736), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(4969), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 439, DateTimeKind.Local).AddTicks(7250), new DateTime(2020, 6, 17, 13, 29, 41, 443, DateTimeKind.Local).AddTicks(4335) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(6228), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 234, DateTimeKind.Local).AddTicks(6934), new DateTime(2020, 6, 17, 12, 38, 4, 234, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(6308), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(4057), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5250), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5243), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5236), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5228), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5221), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5213), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5206), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5199), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5192), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5184), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5177), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5169), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5160), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5096), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5088), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5081), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5073), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5066), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5059), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5051), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5043), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5036), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5000), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4370), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4363), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4356), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4349), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4341), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4333), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4326), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4318), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4309), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4302), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4294), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4287), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4279), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4202), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(1586), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(695), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(687), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(648), new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(9927), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(8303), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(3142), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(3082), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(896), new DateTime(2020, 6, 17, 12, 38, 4, 235, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 12, 38, 4, 226, DateTimeKind.Local).AddTicks(3551), new DateTime(2020, 6, 17, 12, 38, 4, 229, DateTimeKind.Local).AddTicks(3991) });
        }
    }
}
