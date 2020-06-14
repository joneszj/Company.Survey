using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Data.Migrations
{
    public partial class ClientSurveySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "RequestedEndDate",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "RequestedStartDate",
                table: "Surveys");

            migrationBuilder.AddColumn<int>(
                name: "ClientSurveyId",
                table: "Reply",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientSurveyKey",
                table: "ClientSurveys",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "ClientSurveys",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestedEndDate",
                table: "ClientSurveys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestedStartDate",
                table: "ClientSurveys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "Phone" },
                values: new object[] { -1, "Test Company", "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 312, DateTimeKind.Local).AddTicks(7548), "joneszj@gmail.com", "Zachary", true, "Jones", "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 315, DateTimeKind.Local).AddTicks(8236), "555-333-1111" });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(9091), new DateTime(2020, 6, 14, 1, 12, 4, 321, DateTimeKind.Local).AddTicks(9120) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6785), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6778), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6770), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6763), new DateTime(2020, 6, 14, 1, 12, 4, 323, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
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
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(7262), new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.InsertData(
                table: "ClientSurveys",
                columns: new[] { "Id", "ClientId", "ClientSurveyKey", "CreatedBy", "CreatedDate", "IsActive", "IsComplete", "ModifiedBy", "ModifiedDate", "RequestedEndDate", "RequestedStartDate", "SurveyId" },
                values: new object[] { -1, -1, new Guid("00000000-0000-0000-0000-000000000000"), "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(2634), true, false, "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 317, DateTimeKind.Local).AddTicks(2678), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1 });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "ClientSurveyId", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[] { -62, -1, "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 324, DateTimeKind.Local).AddTicks(438), true, "Anonymous", new DateTime(2020, 6, 14, 1, 12, 4, 324, DateTimeKind.Local).AddTicks(454), "Azure", -1 });

            migrationBuilder.CreateIndex(
                name: "IX_Reply_ClientSurveyId",
                table: "Reply",
                column: "ClientSurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_ClientSurveys_ClientSurveyId",
                table: "Reply",
                column: "ClientSurveyId",
                principalTable: "ClientSurveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_ClientSurveys_ClientSurveyId",
                table: "Reply");

            migrationBuilder.DropIndex(
                name: "IX_Reply_ClientSurveyId",
                table: "Reply");

            migrationBuilder.DeleteData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "ClientSurveys",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "ClientSurveyId",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "ClientSurveyKey",
                table: "ClientSurveys");

            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "ClientSurveys");

            migrationBuilder.DropColumn(
                name: "RequestedEndDate",
                table: "ClientSurveys");

            migrationBuilder.DropColumn(
                name: "RequestedStartDate",
                table: "ClientSurveys");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Clients");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Surveys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestedEndDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestedStartDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8394), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8380), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8365), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8350), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8333), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8318), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8303), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8288), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8274), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8259), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8244), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8229), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8214), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8199), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8185), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8168), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8153), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8139), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8124), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8108), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8093), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8078), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8063), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8048), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8033), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8018), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8003), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7989), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7974), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7959), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7944), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7930), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7914), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7899), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7884), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7868), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7852), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7834), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7820), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7805), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7789), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7772), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7756), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7741), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7724), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7709), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7678), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7662), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7647), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7632), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7616), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7600), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7584), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7568), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7552), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7537), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7521), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Reply",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(4680), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "StepContent",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(2610), new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1798), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1736), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1678), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1640), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1593), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1539), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1477), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1425), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1366), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1320), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1288), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1226), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1162), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1116), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1053), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(992), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(958), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(910), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(859), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(797), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(746), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(678), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(535), new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8407), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8357), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8296), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8238), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8187), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8162), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8127), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8101), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8044), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7984), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7924), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7881), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7808), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7520), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestion",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(670), new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(9300), new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8800), new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8727), new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(7486), new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "SurveyQuestionGroup",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(2929), new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(358), new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(231), new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "SurveyStep",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 887, DateTimeKind.Local).AddTicks(4159), new DateTime(2020, 6, 13, 21, 49, 27, 887, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedDate", "DateOfQuestionnaire", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 6, 13, 21, 49, 27, 874, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 6, 13, 21, 49, 27, 881, DateTimeKind.Local).AddTicks(7211) });
        }
    }
}
