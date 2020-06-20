using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AttemptClientSurveysSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClientSurveys",
                columns: new[] { "Id", "ClientId", "ClientSurveyKey", "CreatedBy", "CreatedDate", "IsActive", "IsComplete", "ModifiedBy", "ModifiedDate", "RequestedEndDate", "RequestedStartDate", "SurveyId" },
                values: new object[] { -1, -1, new Guid("00000000-0000-0000-0000-000000000000"), "Anonymous", new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(6228), true, false, "Anonymous", new DateTime(2020, 6, 17, 12, 38, 4, 236, DateTimeKind.Local).AddTicks(6243), null, null, -1 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 429, DateTimeKind.Local).AddTicks(9439), new DateTime(2020, 6, 17, 3, 3, 14, 429, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(457), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(8058), new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3100), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3063), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3037), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3021), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3006), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2993), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2962), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2932), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2916), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2877), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2844), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2811), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2775), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2740), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2728), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2701), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2668), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2634), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2595), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2463), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2390), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2304), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1099), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1085), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1072), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1063), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1054), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1045), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1035), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1026), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1016), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(997), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(987), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(976), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(879), new DateTime(2020, 6, 17, 3, 3, 14, 432, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(7248), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6146), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6136), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6090), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(5020), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(2783), new DateTime(2020, 6, 17, 3, 3, 14, 431, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(6954), new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(6882), new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(4116), new DateTime(2020, 6, 17, 3, 3, 14, 430, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 423, DateTimeKind.Local).AddTicks(9516), new DateTime(2020, 6, 17, 3, 3, 14, 427, DateTimeKind.Local).AddTicks(3463) });
        }
    }
}
