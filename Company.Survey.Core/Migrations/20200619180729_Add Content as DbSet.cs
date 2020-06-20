using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddContentasDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_StepContents_StepContentId",
                table: "Content");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Content",
                table: "Content");

            migrationBuilder.RenameTable(
                name: "Content",
                newName: "ConbentBlocks");

            migrationBuilder.RenameIndex(
                name: "IX_Content_StepContentId",
                table: "ConbentBlocks",
                newName: "IX_ConbentBlocks_StepContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConbentBlocks",
                table: "ConbentBlocks",
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
                name: "FK_ConbentBlocks_StepContents_StepContentId",
                table: "ConbentBlocks",
                column: "StepContentId",
                principalTable: "StepContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConbentBlocks_StepContents_StepContentId",
                table: "ConbentBlocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConbentBlocks",
                table: "ConbentBlocks");

            migrationBuilder.RenameTable(
                name: "ConbentBlocks",
                newName: "Content");

            migrationBuilder.RenameIndex(
                name: "IX_ConbentBlocks_StepContentId",
                table: "Content",
                newName: "IX_Content_StepContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Content",
                table: "Content",
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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 19, 12, 0, 22, 985, DateTimeKind.Local).AddTicks(6911), new DateTime(2020, 6, 19, 12, 0, 22, 988, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.AddForeignKey(
                name: "FK_Content_StepContents_StepContentId",
                table: "Content",
                column: "StepContentId",
                principalTable: "StepContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
