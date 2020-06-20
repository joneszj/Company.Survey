using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class RemoveGroupedQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestionGroup_SurveyQuestionGroupID",
                table: "SurveyQuestion");

            migrationBuilder.DropTable(
                name: "SurveyQuestionGroup");

            migrationBuilder.DropIndex(
                name: "IX_SurveyQuestion_SurveyQuestionGroupID",
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

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyQuestionId", "SurveyStepId" },
                values: new object[,]
                {
                    { -43, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8356), true, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8358), null, 1, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?", "Text", null, null, -3 },
                    { -42, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8351), true, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8353), null, 13, "List the number of Website Names (&amp; Location on Servers if possible)?", "Text", null, null, -2 },
                    { -41, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8346), true, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8348), "(if Yes please List)", 10, "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?", "Text", null, null, -2 },
                    { -40, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8340), true, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8343), "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)", 4, "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?", "Text", null, null, -2 },
                    { -39, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8335), true, "Anonymous", new DateTime(2020, 6, 17, 19, 41, 58, 357, DateTimeKind.Local).AddTicks(8337), null, 1, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?", "Text", null, null, -2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DropIndex(
                name: "IX_SurveyQuestion_SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.DeleteData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DropColumn(
                name: "SurveyQuestionId",
                table: "SurveyQuestion");

            migrationBuilder.CreateTable(
                name: "SurveyQuestionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SurveyStepId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestionGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQuestionGroup_SurveyStep_SurveyStepId",
                        column: x => x.SurveyStepId,
                        principalTable: "SurveyStep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(3599), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(115), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(1324), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(9081), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(8868), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2225), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2216), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2208), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2201), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1181), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1174), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1166), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1159), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1151), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1144), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1137), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1130), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1122), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1115), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1107), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1097), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1074), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(7711), new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.InsertData(
                table: "SurveyQuestionGroup",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "SurveyStepId", "Title" },
                values: new object[,]
                {
                    { -5, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6435), true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6438), null, 1, -3, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" },
                    { -4, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6426), true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6430), null, 13, -2, "List the number of Website Names (&amp; Location on Servers if possible)?" },
                    { -3, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6406), true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(6420), "(if Yes please List)", 10, -2, "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?" },
                    { -2, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(5715), true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(5732), "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)", 4, -2, "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?" },
                    { -1, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(3722), true, "Anonymous", new DateTime(2020, 6, 17, 13, 29, 41, 447, DateTimeKind.Local).AddTicks(3739), null, 1, -2, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" }
                });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7736), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(4969), new DateTime(2020, 6, 17, 13, 29, 41, 446, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 439, DateTimeKind.Local).AddTicks(7250), new DateTime(2020, 6, 17, 13, 29, 41, 443, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2192), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2196), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2183), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2186), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2173), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2176), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2166), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2169), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2158), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2162), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2151), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2154), -4 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2144), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2147), -4 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2136), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2140), -3 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2129), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2132), -3 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2122), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2125), -3 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2114), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2118), -2 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2107), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2110), -2 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2100), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2103), -2 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2092), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2096), -2 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2084), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2087), -2 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2006), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2010), -1 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1999), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(2002), -1 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1995), -1 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1971), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1986), -1 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1190), new DateTime(2020, 6, 17, 13, 29, 41, 448, DateTimeKind.Local).AddTicks(1193), -1 });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyQuestionGroupID",
                table: "SurveyQuestion",
                column: "SurveyQuestionGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestionGroup_SurveyStepId",
                table: "SurveyQuestionGroup",
                column: "SurveyStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_SurveyQuestionGroup_SurveyQuestionGroupID",
                table: "SurveyQuestion",
                column: "SurveyQuestionGroupID",
                principalTable: "SurveyQuestionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
