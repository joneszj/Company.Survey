using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddStepContentasDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_StepContent_StepContentId",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_StepContent_SurveySteps_SurveyStepId",
                table: "StepContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StepContent",
                table: "StepContent");

            migrationBuilder.RenameTable(
                name: "StepContent",
                newName: "StepContents");

            migrationBuilder.RenameIndex(
                name: "IX_StepContent_SurveyStepId",
                table: "StepContents",
                newName: "IX_StepContents_SurveyStepId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StepContents",
                table: "StepContents",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 993, DateTimeKind.Local).AddTicks(102), new DateTime(2020, 6, 19, 12, 0, 22, 993, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 990, DateTimeKind.Local).AddTicks(7101), new DateTime(2020, 6, 19, 12, 0, 22, 990, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(6669), new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 993, DateTimeKind.Local).AddTicks(4581), new DateTime(2020, 6, 19, 12, 0, 22, 993, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "StepContents",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(3406), new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7184), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7174), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7165), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7155), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7147), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7142), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7136), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7130), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7125), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8415), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8408), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8402), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8396), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8390), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8384), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8378), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8372), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8367), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8360), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8348), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8342), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8335), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8329), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8323), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8316), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8233), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7191), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7119), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7113), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7108), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7102), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7094), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7088), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7082), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7076), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7071), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7064), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7059), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7052), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(1709), new DateTime(2020, 6, 19, 12, 0, 22, 992, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(2665), new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(2648), new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(672), new DateTime(2020, 6, 19, 12, 0, 22, 991, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 985, DateTimeKind.Local).AddTicks(6911), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 19, 12, 0, 22, 988, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.AddForeignKey(
                name: "FK_Content_StepContents_StepContentId",
                table: "Content",
                column: "StepContentId",
                principalTable: "StepContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StepContents_SurveySteps_SurveyStepId",
                table: "StepContents",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_StepContents_StepContentId",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_StepContents_SurveySteps_SurveyStepId",
                table: "StepContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StepContents",
                table: "StepContents");

            migrationBuilder.RenameTable(
                name: "StepContents",
                newName: "StepContent");

            migrationBuilder.RenameIndex(
                name: "IX_StepContents_SurveyStepId",
                table: "StepContent",
                newName: "IX_StepContent_SurveyStepId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StepContent",
                table: "StepContent",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(4170), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 799, DateTimeKind.Local).AddTicks(8238), new DateTime(2020, 6, 18, 21, 50, 43, 799, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(7636), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 802, DateTimeKind.Local).AddTicks(507), new DateTime(2020, 6, 18, 21, 50, 43, 802, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4970), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2297), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2291), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2286), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2281), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2275), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2269), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2263), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2257), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2252), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3037), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3031), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3024), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3018), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3013), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3007), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3002), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2996), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2991), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2985), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2979), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2973), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2967), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2961), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2955), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2950), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2944), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2939), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2923), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2302), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2247), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2238), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2232), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2221), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2216), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2210), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2204), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2197), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2191), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2185), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2179), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2161), new DateTime(2020, 6, 18, 21, 50, 43, 801, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(9522), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4106), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4087), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(1882), new DateTime(2020, 6, 18, 21, 50, 43, 800, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 795, DateTimeKind.Local).AddTicks(1500), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 18, 21, 50, 43, 797, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.AddForeignKey(
                name: "FK_Content_StepContent_StepContentId",
                table: "Content",
                column: "StepContentId",
                principalTable: "StepContent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StepContent_SurveySteps_SurveyStepId",
                table: "StepContent",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
