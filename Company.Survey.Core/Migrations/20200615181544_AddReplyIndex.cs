using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddReplyIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupIndex",
                table: "Reply",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(7744), new DateTime(2020, 6, 15, 14, 15, 42, 71, DateTimeKind.Local).AddTicks(7781) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupIndex",
                table: "Reply");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 811, DateTimeKind.Local).AddTicks(7265), new DateTime(2020, 6, 15, 10, 18, 59, 811, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(5134), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(3475), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2764), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2757), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2751), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2744), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2737), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2731), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2724), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2717), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2710), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2697), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2690), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2683), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2677), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2670), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2663), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2657), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2648), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2593), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2586), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2579), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2572), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2539), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1980), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1974), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1967), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1960), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1953), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1947), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1940), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1933), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1925), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1918), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1911), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1904), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1896), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1826), new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(9532), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8774), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8767), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8734), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8218), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(6819), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2695), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2644), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(535), new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 15, 10, 18, 59, 807, DateTimeKind.Local).AddTicks(1652), new DateTime(2020, 6, 15, 10, 18, 59, 809, DateTimeKind.Local).AddTicks(8762) });
        }
    }
}
