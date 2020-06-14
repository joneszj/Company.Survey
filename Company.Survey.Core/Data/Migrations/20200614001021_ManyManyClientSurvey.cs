using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Data.Migrations
{
    public partial class ManyManyClientSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Clients_ClientId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_ClientId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Surveys");

            migrationBuilder.CreateTable(
                name: "ClientSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    SurveyId = table.Column<int>(nullable: false),
                    SurveyId1 = table.Column<int>(nullable: true),
                    SurveyVersion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSurveys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientSurveys_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientSurveys_Surveys_SurveyId1_SurveyVersion",
                        columns: x => new { x.SurveyId1, x.SurveyVersion },
                        principalTable: "Surveys",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(5836), new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1220), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1213), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1206), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1200), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1193), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1187), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1180), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1173), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1167), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1160), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1154), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1147), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1141), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1134), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1128), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1121), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1114), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1108), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1101), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1095), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1088), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1081), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1075), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1068), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1062), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1055), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1048), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1042), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1035), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(954), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(947), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(940), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(934), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(927), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(920), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(913), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(907), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(900), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(894), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(887), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(880), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(873), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(867), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(860), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(853), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(846), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(840), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(833), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(827), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(820), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(814), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(807), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(801), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(794), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(787), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(780), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(773), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(766), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(733), new DateTime(2020, 6, 13, 20, 10, 20, 121, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(9667), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(3271), new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8790), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8783), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8776), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8769), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8763), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8756), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8749), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8742), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8736), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8729), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8722), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8715), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8708), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8701), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8694), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8687), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8680), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8673), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8666), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8658), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8651), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8644), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8608), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7987), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7980), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7973), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7966), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7960), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7946), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7931), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7869), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7862), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7854), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7846), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7771), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(4969), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(4099), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3879), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3844), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3156), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(335), new DateTime(2020, 6, 13, 20, 10, 20, 120, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(2223), new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(2170), new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 118, DateTimeKind.Local).AddTicks(9975), new DateTime(2020, 6, 13, 20, 10, 20, 119, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumns: new[] { "Id", "Version" },
                keyValues: new object[] { -1, 8 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 20, 10, 20, 113, DateTimeKind.Local).AddTicks(7918), new DateTime(2020, 6, 13, 20, 10, 20, 116, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveys_ClientId",
                table: "ClientSurveys",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveys_SurveyId1_SurveyVersion",
                table: "ClientSurveys",
                columns: new[] { "SurveyId1", "SurveyVersion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientSurveys");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Surveys",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(391), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2073), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2066), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2059), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2052), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2046), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2038), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2031), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2024), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2014), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2007), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2000), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1993), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1986), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1979), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1972), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1965), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1958), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1952), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1944), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1937), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1931), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1924), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1917), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1910), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1903), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1896), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1889), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1882), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1875), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1868), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1861), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1854), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1847), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1840), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1833), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1826), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1818), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1811), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1803), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1795), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1788), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1781), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1773), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1766), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1759), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1752), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1745), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1738), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1731), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1723), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1717), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1709), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1703), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1695), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1687), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1680), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1673), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1665), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1630), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(449), new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(7022), new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9583), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9576), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9569), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9561), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9554), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9547), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9539), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9531), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9450), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9442), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9435), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9428), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9420), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9413), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9405), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9398), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9390), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9383), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9375), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9367), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9360), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9352), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9314), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8679), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8672), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8663), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8655), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8647), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8640), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8632), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8625), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8617), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8609), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8602), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8593), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8585), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8508), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5848), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5047), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4849), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4815), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4211), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(2547), new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5637), new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5535), new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(1928), new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumns: new[] { "Id", "Version" },
                keyValues: new object[] { -1, 8 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 19, 54, 53, 571, DateTimeKind.Local).AddTicks(2084), new DateTime(2020, 6, 13, 19, 54, 53, 574, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_ClientId",
                table: "Surveys",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Clients_ClientId",
                table: "Surveys",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
