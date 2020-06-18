using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class Heirarchicalsurveyquestionpatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyQuestionsID",
                table: "SurveyQuestion");

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7247), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7242), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7244) });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7982), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7984), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7976), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7979), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7970), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7973), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7965), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7967), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7959), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7962), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7956), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7948), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7950), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7942), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7944), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7938), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7930), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7932), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7924), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7927), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7919), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7921), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7915), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7907), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7910), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7901), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7904), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7896), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7898), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7890), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7892), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7884), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7886), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7867), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7879), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7259), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7261), -39 });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7191), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7194) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7149), new DateTime(2020, 6, 17, 20, 22, 14, 599, DateTimeKind.Local).AddTicks(7151) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(7674), new DateTime(2020, 6, 17, 20, 22, 14, 598, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 22, 14, 593, DateTimeKind.Local).AddTicks(3606), new DateTime(2020, 6, 17, 20, 22, 14, 596, DateTimeKind.Local).AddTicks(2187) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3352), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3355), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3346), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3349), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3343), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3334), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3336), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3328), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3330), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3321), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3324), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3315), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3318), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3309), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3312), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3306), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3297), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3300), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3291), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3294), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3285), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3287), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3278), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3281), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3272), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3275), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3266), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3269), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3260), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3263), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3254), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3257), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3248), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3250), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3229), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(3242), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "ParentSurveyQuestionId", "SurveyQuestionsID" },
                values: new object[] { new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2440), new DateTime(2020, 6, 17, 20, 15, 58, 248, DateTimeKind.Local).AddTicks(2443), -39 });

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
        }
    }
}
