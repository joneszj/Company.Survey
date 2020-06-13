using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    CompanySite = table.Column<string>(nullable: false),
                    ContactTitle = table.Column<string>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: false),
                    DateOfQuestionnaire = table.Column<DateTime>(nullable: false),
                    RequestedStartDate = table.Column<DateTime>(nullable: false),
                    RequestedEndDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => new { x.Id, x.Version });
                    table.ForeignKey(
                        name: "FK_Surveys_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyStep",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    SurveyId = table.Column<int>(nullable: false),
                    SurveyId1 = table.Column<int>(nullable: true),
                    SurveyVersion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyStep_Surveys_SurveyId1_SurveyVersion",
                        columns: x => new { x.SurveyId1, x.SurveyVersion },
                        principalTable: "Surveys",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StepContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    SurveyStepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StepContent_SurveyStep_SurveyStepId",
                        column: x => x.SurveyStepId,
                        principalTable: "SurveyStep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    SurveyStepId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ContentData = table.Column<string>(nullable: true),
                    StepContentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Content_StepContent_StepContentId",
                        column: x => x.StepContentId,
                        principalTable: "StepContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Quesiton = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    ReplyType = table.Column<string>(nullable: false),
                    SurveyStepId = table.Column<int>(nullable: false),
                    SurveyQuestionGroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_SurveyQuestionGroup_SurveyQuestionGroupID",
                        column: x => x.SurveyQuestionGroupID,
                        principalTable: "SurveyQuestionGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_SurveyStep_SurveyStepId",
                        column: x => x.SurveyStepId,
                        principalTable: "SurveyStep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reply",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ReplyData = table.Column<string>(nullable: true),
                    SurveyQuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reply_SurveyQuestion_SurveyQuestionId",
                        column: x => x.SurveyQuestionId,
                        principalTable: "SurveyQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyId1", "SurveyVersion", "Title" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(1928), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(1955), 0, -1, null, null, "Organization/Company &amp; Primary Contact Details: Step A" },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5535), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5566), 1, -1, null, null, "Source Migration Infrastructure Details: Step B" },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5637), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(5647), 2, -1, null, null, "Destination Migration Infrastructure Details: Step C" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Version", "ClientId", "CompanyName", "CompanySite", "ContactPhone", "ContactTitle", "CreatedBy", "CreatedDate", "DateOfQuestionnaire", "IsActive", "IsComplete", "ModifiedBy", "ModifiedDate", "RequestedEndDate", "RequestedStartDate", "Title" },
                values: new object[] { -1, 8, null, "Databerry", "www.databerry.com", "855-350-0707", "Phone", "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 571, DateTimeKind.Local).AddTicks(2084), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 574, DateTimeKind.Local).AddTicks(8422), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infrastructure Migration Survey Form V8" });

            migrationBuilder.InsertData(
                table: "StepContent",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "SurveyStepId", "Title" },
                values: new object[] { -1, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(7022), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 577, DateTimeKind.Local).AddTicks(7048), -1, "Databerry Migration Process:" });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -37, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9576), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9579), "(e.g. P= Physical V=Virtual P-P, P-V, V-V, V-P)", 3, "Specify the Type of Migration?", "Text", null, -3 },
                    { -36, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9569), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9572), null, 2, "Is there a SAN? (Yes or No)", "Text", null, -3 },
                    { -35, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9561), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9565), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Moving to Hosting Service Provider?", "Text", null, -3 },
                    { -34, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9554), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9557), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", null, -3 },
                    { -33, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9547), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9550), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", null, -3 },
                    { -32, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9539), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9543), null, 2, "OS Type & Version", "Text", null, -3 },
                    { -31, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9531), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9535), null, 1, "Describe the Type of Server", "Text", null, -3 },
                    { -30, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9450), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9453), null, 0, "Name of Server", "Text", null, -3 },
                    { -38, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9583), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9586), null, 4, "Please include any additional technical details that you may feel is important that was not covered above:", "Text", null, -3 },
                    { -13, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8663), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8666), "(e.g. Sendmail v8.7, PHPmailer, Postfix, MS Exchange v2013, Exim)", 14, "Are there any E-mail platforms or services installed on the Server(s) Type | Version?", "Text", null, -2 },
                    { -12, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8655), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8659), "(e.g. IIS 7.0, Apache 2.2, Nginx 1.1)", 14, "List existing Web Server platform &amp; Versions?", "Text", null, -2 },
                    { -14, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8672), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8675), "(e.g. Google analytics data and/or Environment estimated usage of High, Medium, Low)", 15, "Total Monthly estimated average of Usage Traffic and/or Transactions volume?", "Text", null, -2 },
                    { -10, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8640), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8643), null, 11, "Total SSL Certificate(s)?", "Text", null, -2 },
                    { -9, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8632), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8636), "(e.g. Authorize.net, PayPal, Stripe, Magento etc.)", 9, "Are there any E-commerce or Payment Gateways Service/platforms involved?", "Text", null, -2 },
                    { -8, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8625), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8628), "(e.g. iOS Apple swift, Android java, Windows Mobile)", 8, "Are there any Mobile Apps?", "Text", null, -2 },
                    { -7, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8617), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8621), "(Note: VPN will be required if migrating over WAN)", 7, "Active Directory Migration (Yes or No)?", "Text", null, -2 },
                    { -6, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8609), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8613), "(e.g. Joomla 2.x, Drupal 7.2, WordPress 4.1, QuickBooks v18.0 etc.)", 6, "Are there any Third-party commercial applications or platforms | API’s | Plug-ins?", "Text", null, -2 },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8602), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8605), "(e.g. .NET 4.5 | PHP 5.4 | Java 1.5)", 6, "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?", "Text", null, -2 },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8593), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8597), "", 5, "Total Count of Database(s)?", "Text", null, -2 },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8585), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8589), "", 3, "Is there a SAN? (Yes or No)", "Text", null, -2 },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8508), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8522), "", 2, "Total count of Server(s)?", "Text", null, -2 },
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5848), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5862), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Current Hosting Service Provider?", "Text", null, -2 },
                    { -11, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8647), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8651), "(e.g. Webmin v1.89, Plesk v12.5, CPanel v58, Docker v17.x)", 12, "Is there any Server Control Panels installed?", "Text", null, -2 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestionGroup",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "SurveyStepId", "Title" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(2547), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(2564), null, 1, -2, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4211), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4224), "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)", 4, -2, "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?" },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4815), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4827), "(if Yes please List)", 10, -2, "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?" },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4849), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(4852), null, 13, -2, "List the number of Website Names (&amp; Location on Servers if possible)?" },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5047), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(5054), null, 1, -3, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "ContentData", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "StepContentId" },
                values: new object[] { -1, "<img src=\\\"/images/databerrymigrationprocess.jpg\\\" alt=\\\"migration process\\\">", "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(391), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(417), -1 });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[,]
                {
                    { -45, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1965), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1969), "Database", -31 },
                    { -46, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1972), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1976), "Application", -31 },
                    { -47, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1979), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1983), "Web", -31 },
                    { -48, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1986), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1989), "Other", -31 },
                    { -49, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1993), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1996), "Windows 2016", -32 },
                    { -50, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2000), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2004), "CentOS v7.2", -32 },
                    { -44, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1958), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1962), "e.g. DC4", -30 },
                    { -51, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2007), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2011), "Redhat v7.0", -32 },
                    { -53, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2024), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2028), "500GB C:", -33 },
                    { -55, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2031), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2035), "700GB's each C: &amp; D:", -33 },
                    { -56, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2038), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2042), "1TB F:", -33 },
                    { -57, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2046), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2049), "2TB each P: &amp; Z:", -33 },
                    { -58, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2052), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2056), "VM", -34 },
                    { -59, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2059), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2063), "Physical", -34 },
                    { -52, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2014), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2017), "Windows 2016 DC", -32 },
                    { -43, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1952), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1955), "e.g. Web01", -30 },
                    { -42, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1944), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1948), "e.g. AppSI", -30 },
                    { -41, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1937), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1941), "e.g. db1", -30 },
                    { -60, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2066), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2070), "VM", -34 },
                    { -61, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2073), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(2077), "Hyper-Visor", -34 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -27, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9428), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9431), null, 2, "SSL Location (Server Name/Location)", "Text", -3, -2 },
                    { -26, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9420), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9424), null, 1, "SSL Type", "Text", -3, -2 },
                    { -25, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9413), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9416), null, 0, "SSL Name", "Text", -3, -2 },
                    { -24, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9405), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9409), null, 4, "Total DB Size in (MB's GB'S TB'S)", "Text", -2, -2 },
                    { -23, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9398), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9401), null, 3, "DB Location", "Text", -2, -2 },
                    { -29, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9442), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9446), null, 1, "Website Location (Server Name/Location)", "Text", -4, -2 },
                    { -21, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9383), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9386), null, 1, "DB Engine Type &amp; Version", "Text", -2, -2 },
                    { -20, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9375), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9379), null, 0, "DB Server Name", "Text", -2, -2 },
                    { -19, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9367), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9371), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", -1, -2 },
                    { -18, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9360), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9363), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", -1, -2 },
                    { -17, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9352), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9355), null, 2, "OS Type & Version", "Text", -1, -2 },
                    { -16, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9314), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9327), null, 1, "Describe the Type of Server", "Text", -1, -2 },
                    { -15, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8679), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(8682), null, 0, "Name of Server", "Text", -1, -2 },
                    { -28, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9435), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9438), null, 0, "Website Name", "Text", -4, -2 },
                    { -22, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9390), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 578, DateTimeKind.Local).AddTicks(9394), null, 2, "DB Name", "Text", -2, -2 }
                });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(449), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(464), "e.g. db1", -15 },
                    { -23, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1811), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1815), "MS SQL 2012", -21 },
                    { -24, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1818), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1822), "MySQL", -21 },
                    { -25, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1826), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1829), "Sales_DB", -22 },
                    { -26, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1833), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1836), "Support_DB", -22 },
                    { -27, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1840), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1843), "C:\\somewhere\\", -23 },
                    { -28, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1847), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1850), "D:\\somewhere\\", -23 },
                    { -29, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1854), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1857), "1GB", -24 },
                    { -22, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1803), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1806), "e.g. Web02", -20 },
                    { -30, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1861), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1864), "Physical", -24 },
                    { -32, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1875), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1878), "e.g. www.mysite.com", -26 },
                    { -33, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1882), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1885), "Wildcard", -26 },
                    { -34, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1889), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1892), "single", -26 },
                    { -35, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1896), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1899), "Web01 C:\\somewhere\\", -27 },
                    { -36, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1903), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1906), "Web02 D:\\somewhere\\", -27 },
                    { -37, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1910), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1913), "e.g. www.mysite.com", -28 },
                    { -38, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1917), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1920), "e.g. my.app.com", -28 },
                    { -31, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1868), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1871), "e.g. *.mysite.com", -25 },
                    { -21, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1795), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1799), "e.g. db1", -20 },
                    { -20, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1788), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1791), "Hyper-Visor", -19 },
                    { -19, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1781), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1784), "VM", -19 },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1630), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1643), "e.g. AppSI", -15 },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1665), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1669), "e.g. Web01", -15 },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1673), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1676), "e.g. DC4", -15 },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1680), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1683), "Database", -16 },
                    { -6, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1687), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1691), "Application", -16 },
                    { -7, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1695), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1699), "Web", -16 },
                    { -8, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1703), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1706), "Other", -16 },
                    { -9, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1709), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1713), "Windows 2016", -17 },
                    { -10, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1717), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1720), "CentOS v7.2", -17 },
                    { -11, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1723), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1727), "Redhat v7.0", -17 },
                    { -12, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1731), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1734), "Windows 2016 DC", -17 },
                    { -13, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1738), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1741), "500GB C:", -18 },
                    { -14, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1745), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1748), "700GB's each C: &amp; D: ", -18 },
                    { -15, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1752), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1755), "1TB F:", -18 },
                    { -16, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1759), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1762), "2TB each P: &amp; Z:", -18 },
                    { -17, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1766), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1770), "VM", -19 },
                    { -18, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1773), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1777), "Physical", -19 },
                    { -39, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1924), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1927), "Web01 C:\\somewhere\\", -29 },
                    { -40, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1931), true, "Anonymous", new DateTime(2020, 6, 13, 19, 54, 53, 579, DateTimeKind.Local).AddTicks(1934), "Web01 D:\\somewhere\\", -29 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Content_StepContentId",
                table: "Content",
                column: "StepContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_SurveyQuestionId",
                table: "Reply",
                column: "SurveyQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_StepContent_SurveyStepId",
                table: "StepContent",
                column: "SurveyStepId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyQuestionGroupID",
                table: "SurveyQuestion",
                column: "SurveyQuestionGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyStepId",
                table: "SurveyQuestion",
                column: "SurveyStepId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestionGroup_SurveyStepId",
                table: "SurveyQuestionGroup",
                column: "SurveyStepId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_ClientId",
                table: "Surveys",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyStep_SurveyId1_SurveyVersion",
                table: "SurveyStep",
                columns: new[] { "SurveyId1", "SurveyVersion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "StepContent");

            migrationBuilder.DropTable(
                name: "SurveyQuestion");

            migrationBuilder.DropTable(
                name: "SurveyQuestionGroup");

            migrationBuilder.DropTable(
                name: "SurveyStep");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
