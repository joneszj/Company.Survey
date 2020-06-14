using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Data.Migrations
{
    public partial class SeedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateCheckConstraint(
                name: "CK_SurveyQuestion_ReplyType_Enum_Constraint",
                table: "SurveyQuestion",
                sql: "[ReplyType] IN(N'Text', N'Multiple', N'Select')");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 330, DateTimeKind.Local).AddTicks(1944), new DateTime(2020, 6, 14, 17, 45, 39, 330, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 324, DateTimeKind.Local).AddTicks(3884), new DateTime(2020, 6, 14, 17, 45, 39, 329, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(5977), new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 339, DateTimeKind.Local).AddTicks(852), new DateTime(2020, 6, 14, 17, 45, 39, 339, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9773), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9739), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9696), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9656), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9631), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9593), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9554), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9514), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9474), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9429), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9403), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9373), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9335), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9289), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9254), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9210), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9109), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9071), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9026), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8992), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8947), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8907), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8881), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8844), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8804), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8764), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8725), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8682), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8649), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8623), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8595), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8557), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8512), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8478), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8432), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8392), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8368), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8334), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8296), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8248), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8214), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8170), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7971), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7949), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7920), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7877), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7604), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7575), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7534), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7497), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7474), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7450), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7412), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7376), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7348), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7303), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7203), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(4715), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(1695), new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3110), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3100), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3091), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3079), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3069), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3074), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3059), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3064), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3049), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3054), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3039), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3044), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3029), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3034), -5 });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3019), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3010), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3000), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2990), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2980), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2970), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2960), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2947), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2937), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2927), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2917), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2908), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2896), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2845), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1755), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1745), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1735), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1726), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1715), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1704), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1694), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1684), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1673), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1664), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1653), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1644), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1632), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1516), new DateTime(2020, 6, 14, 17, 45, 39, 338, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(5719), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3868), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3571), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3520), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(2701), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(331), new DateTime(2020, 6, 14, 17, 45, 39, 337, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(2), new DateTime(2020, 6, 14, 17, 45, 39, 336, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 335, DateTimeKind.Local).AddTicks(9831), new DateTime(2020, 6, 14, 17, 45, 39, 335, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 335, DateTimeKind.Local).AddTicks(3808), new DateTime(2020, 6, 14, 17, 45, 39, 335, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 17, 45, 39, 330, DateTimeKind.Local).AddTicks(8096), new DateTime(2020, 6, 14, 17, 45, 39, 330, DateTimeKind.Local).AddTicks(8141) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_SurveyQuestion_ReplyType_Enum_Constraint",
                table: "SurveyQuestion");

            migrationBuilder.UpdateData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(2634), new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 312, DateTimeKind.Local).AddTicks(7548), new DateTime(2020, 6, 14, 1, 12, 4, 315, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(9091), new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 324, DateTimeKind.Local).AddTicks(438), new DateTime(2020, 6, 14, 1, 12, 4, 324, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9820), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9813), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9805), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9798), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9791), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9783), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9711), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9703), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9696), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9689), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9682), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9674), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9667), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9660), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9652), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9645), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9638), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9631), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9623), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9616), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9609), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9602), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9594), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9587), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9580), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9564), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9556), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9549), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9542), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9534), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9527), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9519), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9512), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9505), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9497), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9490), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9483), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9476), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9468), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9461), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9454), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9446), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9439), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9431), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9424), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9416), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9409), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9402), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9394), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9386), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9379), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9371), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9364), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9355), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9347), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9340), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9332), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9295), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(7909), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(5578), new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6815), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6808), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6801), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6793), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6785), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6778), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6770), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6763), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate", "SurveyQuestionGroupID" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6755), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6746), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6652), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6644), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6636), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6629), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6621), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6614), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6606), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6597), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6589), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6581), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6574), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6566), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6524), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5718), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5710), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5702), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5694), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5687), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5679), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5672), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5664), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5656), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5649), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5640), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5632), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5623), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5537), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(410), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(9140), new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(8688), new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(8607), new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(7385), new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(3263), new DateTime(2020, 6, 14, 1, 12, 4, 322, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(3767), new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 320, DateTimeKind.Local).AddTicks(9092), new DateTime(2020, 6, 14, 1, 12, 4, 320, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(7262), new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(7293) });
        }
    }
}
