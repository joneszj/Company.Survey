using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class AddSurveySteptoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StepContent_SurveyStep_SurveyStepId",
                table: "StepContent");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyStep_SurveyStepId",
                table: "SurveyQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyStep",
                table: "SurveyStep");

            migrationBuilder.RenameTable(
                name: "SurveyStep",
                newName: "SurveySteps");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyStep_SurveyId_SurveyVersion",
                table: "SurveySteps",
                newName: "IX_SurveySteps_SurveyId_SurveyVersion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveySteps",
                table: "SurveySteps",
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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 21, 50, 43, 795, DateTimeKind.Local).AddTicks(1500), new DateTime(2020, 6, 18, 21, 50, 43, 797, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.AddForeignKey(
                name: "FK_StepContent_SurveySteps_SurveyStepId",
                table: "StepContent",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveySteps_SurveyStepId",
                table: "SurveyQuestion",
                column: "SurveyStepId",
                principalTable: "SurveySteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySteps_Surveys_SurveyId_SurveyVersion",
                table: "SurveySteps",
                columns: new[] { "SurveyId", "SurveyVersion" },
                principalTable: "Surveys",
                principalColumns: new[] { "Id", "Version" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StepContent_SurveySteps_SurveyStepId",
                table: "StepContent");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveySteps_SurveyStepId",
                table: "SurveyQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveySteps_Surveys_SurveyId_SurveyVersion",
                table: "SurveySteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveySteps",
                table: "SurveySteps");

            migrationBuilder.RenameTable(
                name: "SurveySteps",
                newName: "SurveyStep");

            migrationBuilder.RenameIndex(
                name: "IX_SurveySteps_SurveyId_SurveyVersion",
                table: "SurveyStep",
                newName: "IX_SurveyStep_SurveyId_SurveyVersion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyStep",
                table: "SurveyStep",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(236), new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(6143), new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(4108), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(4357), new DateTime(2020, 6, 18, 16, 35, 2, 742, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(2392), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8484), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8478), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8472), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8466), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8461), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8456), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8451), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8445), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8439), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9234), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9228), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9223), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9218), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9212), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9207), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9202), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9195), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9189), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9184), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9178), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9173), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9162), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9157), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9151), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9141), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9125), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8546), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8434), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8428), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8423), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8418), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8412), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8407), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8401), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8394), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8389), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8383), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8378), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8371), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1567), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1549), new DateTime(2020, 6, 18, 16, 35, 2, 741, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(9559), new DateTime(2020, 6, 18, 16, 35, 2, 740, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 18, 16, 35, 2, 736, DateTimeKind.Local).AddTicks(1334), new DateTime(2020, 6, 18, 16, 35, 2, 738, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.AddForeignKey(
                name: "FK_StepContent_SurveyStep_SurveyStepId",
                table: "StepContent",
                column: "SurveyStepId",
                principalTable: "SurveyStep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveyStep_SurveyStepId",
                table: "SurveyQuestion",
                column: "SurveyStepId",
                principalTable: "SurveyStep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                table: "SurveyStep",
                columns: new[] { "SurveyId", "SurveyVersion" },
                principalTable: "Surveys",
                principalColumns: new[] { "Id", "Version" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
