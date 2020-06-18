using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class RemoveGroupedQuestionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyQuestionGroupID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyGroupQuestionsID",
                table: "SurveyQuestion");

            migrationBuilder.AddColumn<int>(
                name: "SurveyQuestionGroupID",
                table: "SurveyQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 358, DateTimeKind.Local).AddTicks(98), new DateTime(2020, 6, 17, 19, 41, 58, 358, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 356, DateTimeKind.Local).AddTicks(5280), new DateTime(2020, 6, 17, 19, 41, 58, 356, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(4051), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 358, DateTimeKind.Local).AddTicks(4162), new DateTime(2020, 6, 17, 19, 41, 58, 358, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(2274), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8356), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8351), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8346), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8340), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8335), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8330), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8324), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8319), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8314), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9094), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9096), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9089), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9091), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9083), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9086), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9078), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9080), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9073), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9075), -43 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9067), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9070), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9062), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9065), -42 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9057), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9059), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9051), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9054), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9046), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9048), -41 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9040), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9043), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9035), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9038), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9030), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9032), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9024), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9027), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9018), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(9021), -40 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8958), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8960), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8952), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8955), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8947), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8949), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8932), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8943), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8361), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8363), -39 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8309), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8302), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8295), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8290), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8285), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8280), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8274), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8269), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8263), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8257), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8252), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8245), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8229), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(5800), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(1419), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(1403), new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 356, DateTimeKind.Local).AddTicks(9295), new DateTime(2020, 6, 17, 19, 41, 58, 356, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 19, 41, 58, 351, DateTimeKind.Local).AddTicks(4451), new DateTime(2020, 6, 17, 19, 41, 58, 354, DateTimeKind.Local).AddTicks(6598) });
        }
    }
}
