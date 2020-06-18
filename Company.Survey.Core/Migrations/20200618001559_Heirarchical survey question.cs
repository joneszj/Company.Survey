using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class Heirarchicalsurveyquestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropIndex(
                name: "IX_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropColumn(
                name: "SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.AddColumn<int>(
                name: "ParentSurveyQuestionId",
                table: "SurveyQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(4819), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 246, DateTimeKind.Local).AddTicks(7437), new DateTime(2020, 6, 17, 20, 15, 58, 246, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(7651), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(9495), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(5299), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2435), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2430), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2425), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2420), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2415), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2409), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2399), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2394), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3352), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3346), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3334), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3328), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3321), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3315), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3309), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3297), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3291), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3285), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3278), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3272), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3266), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3260), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3254), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3248), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3229), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2440), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2387), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2382), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2377), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2371), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2366), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2360), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2355), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2349), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2344), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2338), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2332), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2327), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2309), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(9464), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(4156), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(4137), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(1923), new DateTime(2020, 6, 17, 20, 15, 58, 247, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 241, DateTimeKind.Local).AddTicks(1790), new DateTime(2020, 6, 17, 20, 15, 58, 244, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion",
                column: "ParentSurveyQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion",
                column: "ParentSurveyQuestionId",
                principalTable: "SurveyQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropIndex(
                name: "IX_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropColumn(
                name: "ParentSurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.AddColumn<int>(
                name: "SurveyQuestionId",
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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1257), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1252), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1246), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1241), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1236), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1230), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1225), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1220), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1214), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1209), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1204), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1198), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1193), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1187), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1182), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1177), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1172), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1150), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(414), new DateTime(2020, 6, 17, 20, 11, 32, 732, DateTimeKind.Local).AddTicks(416) });

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

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion",
                column: "SurveyQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion",
                column: "SurveyQuestionId",
                principalTable: "SurveyQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
