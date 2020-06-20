using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddSurveyQuestionasDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_SurveyQuestion_SurveyQuestionId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveySteps_SurveyStepId",
                table: "SurveyQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyQuestion",
                table: "SurveyQuestion");

            migrationBuilder.RenameTable(
                name: "SurveyQuestion",
                newName: "Questions");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_SurveyStepId",
                table: "Questions",
                newName: "IX_Questions_SurveyStepId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_ParentSurveyQuestionId",
                table: "Questions",
                newName: "IX_Questions_ParentSurveyQuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(5734), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(1712), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "ConbentBlocks",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(9646), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4002), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3945), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3939), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3934), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3929), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3924), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3917), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3910), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3902), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4699), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4694), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4688), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4683), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4678), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4672), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4667), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4662), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4656), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4651), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4646), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4640), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4635), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4630), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4624), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4619), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4613), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4607), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4592), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4009), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3896), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3891), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3885), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3879), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3874), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3868), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3862), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3856), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3851), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3846), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3840), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3833), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3817), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(1390), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(9765), new DateTime(2020, 6, 19, 15, 57, 26, 430, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "StepContents",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7969), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7251), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7233), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(5250), new DateTime(2020, 6, 19, 15, 57, 26, 429, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 15, 57, 26, 423, DateTimeKind.Local).AddTicks(8063), new DateTime(2020, 6, 19, 15, 57, 26, 427, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Questions_ParentSurveyQuestionId",
                table: "Questions",
                column: "ParentSurveyQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SurveySteps_SurveyStepId",
                table: "Questions",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Questions_SurveyQuestionId",
                table: "Reply",
                column: "SurveyQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Questions_ParentSurveyQuestionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SurveySteps_SurveyStepId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Questions_SurveyQuestionId",
                table: "Reply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "SurveyQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SurveyStepId",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_SurveyStepId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ParentSurveyQuestionId",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_ParentSurveyQuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyQuestion",
                table: "SurveyQuestion",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(8860), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 964, DateTimeKind.Local).AddTicks(1639), new DateTime(2020, 6, 19, 14, 7, 27, 964, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "ConbentBlocks",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(6408), new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 967, DateTimeKind.Local).AddTicks(7359), new DateTime(2020, 6, 19, 14, 7, 27, 967, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "StepContents",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(2935), new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5331), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5321), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5310), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5297), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5179), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5168), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5156), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5144), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5133), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6750), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6739), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6729), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6718), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6707), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6697), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6686), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6675), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6664), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6653), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6643), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6632), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6621), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6611), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6600), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6590), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6579), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6567), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6537), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5341), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5121), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5110), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5099), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5088), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5077), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5065), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5054), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5042), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5030), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5018), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5005), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(4994), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(4961), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(9984), new DateTime(2020, 6, 19, 14, 7, 27, 966, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(1399), new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(1364), new DateTime(2020, 6, 19, 14, 7, 27, 965, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "SurveySteps",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 964, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 6, 19, 14, 7, 27, 964, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 14, 7, 27, 956, DateTimeKind.Local).AddTicks(1162), new DateTime(2020, 6, 19, 14, 7, 27, 960, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_SurveyQuestion_SurveyQuestionId",
                table: "Reply",
                column: "SurveyQuestionId",
                principalTable: "SurveyQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_ParentSurveyQuestionId",
                table: "SurveyQuestion",
                column: "ParentSurveyQuestionId",
                principalTable: "SurveyQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveySteps_SurveyStepId",
                table: "SurveyQuestion",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
