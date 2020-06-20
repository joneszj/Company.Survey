using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class replaceampersandinseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1537), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1539), "List the number of Website Names (& Location on Servers if possible)?" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1532), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1534), "Are there any SSL certificate(s) installed (Type & Location If possible)?" });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2163), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(2165), "DB Engine Type & Version" });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1484), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1486), "List existing Web Server platform & Versions?" });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1445), new DateTime(2020, 6, 17, 23, 22, 28, 212, DateTimeKind.Local).AddTicks(1448), "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions & Names ?" });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(2603), new DateTime(2020, 6, 17, 23, 22, 28, 211, DateTimeKind.Local).AddTicks(2619), "Organization/Company & Primary Contact Details: Step A" });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 23, 22, 28, 206, DateTimeKind.Local).AddTicks(1750), new DateTime(2020, 6, 17, 23, 22, 28, 209, DateTimeKind.Local).AddTicks(848) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(9250), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(3905), new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(2611), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 600, DateTimeKind.Local).AddTicks(3500), new DateTime(2020, 6, 17, 20, 22, 14, 600, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(736), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7253), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7247), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7250), "List the number of Website Names (&amp; Location on Servers if possible)?" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7242), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7244), "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7236), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7230), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7225), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7219), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7214), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7208), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7982), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7976), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7970), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7965), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7959), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7948), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7942), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7930), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7924), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7919), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7907), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7910), "DB Engine Type &amp; Version" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7901), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7896), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7890), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7884), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7867), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7259), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7202), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7197), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7191), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7194), "List existing Web Server platform &amp; Versions?" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7185), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7180), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7174), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7168), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7161), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7156), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Quesiton" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7149), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7151), "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?" });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7143), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7134), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7049), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(4507), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(9865), new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(9848), new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(7674), new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(7691), "Organization/Company &amp; Primary Contact Details: Step A" });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 593, DateTimeKind.Local).AddTicks(3606), new DateTime(2020, 6, 17, 20, 22, 14, 596, DateTimeKind.Local).AddTicks(2187) });
        }
    }
}
