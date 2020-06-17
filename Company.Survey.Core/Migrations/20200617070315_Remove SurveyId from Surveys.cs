using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class RemoveSurveyIdfromSurveys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Surveys_SuveryId_Version",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_SuveryId_Version",
                table: "Surveys");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SurveyQuestion_ReplyType_Enum_Constraint",
                table: "SurveyQuestion");

            migrationBuilder.DropColumn(
                name: "SuveryId",
                table: "Surveys");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Surveys_Id_Version",
                table: "Surveys",
                columns: new[] { "Id", "Version" });

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
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 3, 3, 14, 423, DateTimeKind.Local).AddTicks(9516), new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 17, 3, 3, 14, 427, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_Id_Version",
                table: "Surveys",
                columns: new[] { "Id", "Version" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep",
                columns: new[] { "SurveyId", "SurveyVersion" },
                principalTable: "Surveys",
                principalColumns: new[] { "Id", "Version" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Surveys_Id_Version",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_Id_Version",
                table: "Surveys");

            migrationBuilder.CreateCheckConstraint(
                name: "CK_SurveyQuestion_ReplyType_Enum_Constraint",
                table: "SurveyQuestion",
                sql: "[ReplyType] IN(N'Text', N'TextArea', N'Multiple', N'Select')");

            migrationBuilder.AddColumn<int>(
                name: "SuveryId",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Surveys_SuveryId_Version",
                table: "Surveys",
                columns: new[] { "SuveryId", "Version" });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(792), new DateTime(2020, 6, 15, 20, 47, 23, 883, DateTimeKind.Local).AddTicks(806) });

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
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 20, 47, 23, 877, DateTimeKind.Local).AddTicks(6573), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 15, 20, 47, 23, 880, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_SuveryId_Version",
                table: "Surveys",
                columns: new[] { "SuveryId", "Version" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep",
                columns: new[] { "SurveyId", "SurveyVersion" },
                principalTable: "Surveys",
                principalColumns: new[] { "SuveryId", "Version" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
