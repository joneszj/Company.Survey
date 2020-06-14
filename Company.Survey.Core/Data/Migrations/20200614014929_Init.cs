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
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SuveryId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    CompanySite = table.Column<string>(nullable: false),
                    ContactTitle = table.Column<string>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: false),
                    DateOfQuestionnaire = table.Column<DateTime>(nullable: false),
                    RequestedStartDate = table.Column<DateTime>(nullable: false),
                    RequestedEndDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                    table.UniqueConstraint("AK_Surveys_SuveryId_Version", x => new { x.SuveryId, x.Version });
                });

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
                    SurveyId = table.Column<int>(nullable: false)
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
                        name: "FK_ClientSurveys_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    SurveyVersion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyStep_Surveys_SurveyId_SurveyVersion",
                        columns: x => new { x.SurveyId, x.SurveyVersion },
                        principalTable: "Surveys",
                        principalColumns: new[] { "SuveryId", "Version" },
                        onDelete: ReferentialAction.Cascade);
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
                table: "Surveys",
                columns: new[] { "Id", "CompanyName", "CompanySite", "ContactPhone", "ContactTitle", "CreatedBy", "CreatedDate", "DateOfQuestionnaire", "IsActive", "IsComplete", "ModifiedBy", "ModifiedDate", "RequestedEndDate", "RequestedStartDate", "SuveryId", "Title", "Version" },
                values: new object[] { -1, "Databerry", "www.databerry.com", "855-350-0707", "Phone", "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 874, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), true, false, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 881, DateTimeKind.Local).AddTicks(7211), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, "Infrastructure Migration Survey Form V8", 8 });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -1, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 887, DateTimeKind.Local).AddTicks(4159), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 887, DateTimeKind.Local).AddTicks(4244), 0, -1, 8, "Organization/Company &amp; Primary Contact Details: Step A" });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -2, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(231), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(278), 1, -1, 8, "Source Migration Infrastructure Details: Step B" });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -3, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(358), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(365), 2, -1, 8, "Destination Migration Infrastructure Details: Step C" });

            migrationBuilder.InsertData(
                table: "StepContent",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "SurveyStepId", "Title" },
                values: new object[] { -1, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(2610), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(2642), -1, "Databerry Migration Process:" });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -37, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1736), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1763), "(e.g. P= Physical V=Virtual P-P, P-V, V-V, V-P)", 3, "Specify the Type of Migration?", "Text", null, -3 },
                    { -36, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1678), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1705), null, 2, "Is there a SAN? (Yes or No)", "Text", null, -3 },
                    { -35, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1640), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1660), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Moving to Hosting Service Provider?", "Text", null, -3 },
                    { -34, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1593), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1619), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", null, -3 },
                    { -33, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1539), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1567), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", null, -3 },
                    { -32, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1477), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1507), null, 2, "OS Type & Version", "Text", null, -3 },
                    { -31, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1425), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1454), null, 1, "Describe the Type of Server", "Text", null, -3 },
                    { -30, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1366), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1393), null, 0, "Name of Server", "Text", null, -3 },
                    { -38, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1798), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1824), null, 4, "Please include any additional technical details that you may feel is important that was not covered above:", "Text", null, -3 },
                    { -13, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8296), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8325), "(e.g. Sendmail v8.7, PHPmailer, Postfix, MS Exchange v2013, Exim)", 14, "Are there any E-mail platforms or services installed on the Server(s) Type | Version?", "Text", null, -2 },
                    { -12, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8238), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8264), "(e.g. IIS 7.0, Apache 2.2, Nginx 1.1)", 14, "List existing Web Server platform &amp; Versions?", "Text", null, -2 },
                    { -14, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8357), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8375), "(e.g. Google analytics data and/or Environment estimated usage of High, Medium, Low)", 15, "Total Monthly estimated average of Usage Traffic and/or Transactions volume?", "Text", null, -2 },
                    { -10, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8162), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8173), null, 11, "Total SSL Certificate(s)?", "Text", null, -2 },
                    { -9, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8127), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8136), "(e.g. Authorize.net, PayPal, Stripe, Magento etc.)", 9, "Are there any E-commerce or Payment Gateways Service/platforms involved?", "Text", null, -2 },
                    { -8, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8101), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8116), "(e.g. iOS Apple swift, Android java, Windows Mobile)", 8, "Are there any Mobile Apps?", "Text", null, -2 },
                    { -7, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8044), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8070), "(Note: VPN will be required if migrating over WAN)", 7, "Active Directory Migration (Yes or No)?", "Text", null, -2 },
                    { -6, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7984), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8013), "(e.g. Joomla 2.x, Drupal 7.2, WordPress 4.1, QuickBooks v18.0 etc.)", 6, "Are there any Third-party commercial applications or platforms | API’s | Plug-ins?", "Text", null, -2 },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7924), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7955), "(e.g. .NET 4.5 | PHP 5.4 | Java 1.5)", 6, "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?", "Text", null, -2 },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7881), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7904), "", 5, "Total Count of Database(s)?", "Text", null, -2 },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7808), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7842), "", 3, "Is there a SAN? (Yes or No)", "Text", null, -2 },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7520), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(7573), "", 2, "Total count of Server(s)?", "Text", null, -2 },
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(670), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(700), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Current Hosting Service Provider?", "Text", null, -2 },
                    { -11, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8187), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8208), "(e.g. Webmin v1.89, Plesk v12.5, CPanel v58, Docker v17.x)", 12, "Is there any Server Control Panels installed?", "Text", null, -2 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestionGroup",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "SurveyStepId", "Title" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(2929), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(2981), null, 1, -2, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(7486), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(7518), "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)", 4, -2, "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?" },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8727), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8754), "(if Yes please List)", 10, -2, "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?" },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8800), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(8809), null, 13, -2, "List the number of Website Names (&amp; Location on Servers if possible)?" },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(9300), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 889, DateTimeKind.Local).AddTicks(9314), null, 1, -3, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "ContentData", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "StepContentId" },
                values: new object[] { -1, "<img src=\\\"/images/databerrymigrationprocess.jpg\\\" alt=\\\"migration process\\\">", "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(7630), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 888, DateTimeKind.Local).AddTicks(7682), -1 });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[,]
                {
                    { -45, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8168), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8175), "Database", -31 },
                    { -46, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8185), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8191), "Application", -31 },
                    { -47, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8199), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8206), "Web", -31 },
                    { -48, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8214), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8221), "Other", -31 },
                    { -49, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8229), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8236), "Windows 2016", -32 },
                    { -50, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8244), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8251), "CentOS v7.2", -32 },
                    { -44, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8153), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8160), "e.g. DC4", -30 },
                    { -51, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8259), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8266), "Redhat v7.0", -32 },
                    { -53, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8288), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8295), "500GB C:", -33 },
                    { -55, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8303), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8310), "700GB's each C: &amp; D:", -33 },
                    { -56, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8318), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8325), "1TB F:", -33 },
                    { -57, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8333), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8341), "2TB each P: &amp; Z:", -33 },
                    { -58, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8350), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8357), "VM", -34 },
                    { -59, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8365), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8372), "Physical", -34 },
                    { -52, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8274), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8280), "Windows 2016 DC", -32 },
                    { -43, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8139), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8146), "e.g. Web01", -30 },
                    { -42, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8124), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8131), "e.g. AppSI", -30 },
                    { -41, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8108), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8114), "e.g. db1", -30 },
                    { -60, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8380), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8387), "VM", -34 },
                    { -61, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8394), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8401), "Hyper-Visor", -34 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -27, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1226), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1252), null, 2, "SSL Location (Server Name/Location)", "Text", -3, -2 },
                    { -26, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1162), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1191), null, 1, "SSL Type", "Text", -3, -2 },
                    { -25, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1116), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1133), null, 0, "SSL Name", "Text", -3, -2 },
                    { -24, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1053), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1082), null, 4, "Total DB Size in (MB's GB'S TB'S)", "Text", -2, -2 },
                    { -23, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(992), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1021), null, 3, "DB Location", "Text", -2, -2 },
                    { -29, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1320), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1335), null, 1, "Website Location (Server Name/Location)", "Text", -4, -2 },
                    { -21, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(910), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(940), null, 1, "DB Engine Type &amp; Version", "Text", -2, -2 },
                    { -20, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(859), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(882), null, 0, "DB Server Name", "Text", -2, -2 },
                    { -19, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(797), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(826), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", -1, -2 },
                    { -18, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(746), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(774), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", -1, -2 },
                    { -17, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(678), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(709), null, 2, "OS Type & Version", "Text", -1, -2 },
                    { -16, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(535), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(589), null, 1, "Describe the Type of Server", "Text", -1, -2 },
                    { -15, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8407), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 890, DateTimeKind.Local).AddTicks(8435), null, 0, "Name of Server", "Text", -1, -2 },
                    { -28, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1288), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(1301), null, 0, "Website Name", "Text", -4, -2 },
                    { -22, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(958), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(977), null, 2, "DB Name", "Text", -2, -2 }
                });

            migrationBuilder.InsertData(
                table: "Reply",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "ReplyData", "SurveyQuestionId" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(4680), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(4723), "e.g. db1", -15 },
                    { -23, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7834), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7841), "MS SQL 2012", -21 },
                    { -24, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7852), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7860), "MySQL", -21 },
                    { -25, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7868), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7875), "Sales_DB", -22 },
                    { -26, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7884), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7891), "Support_DB", -22 },
                    { -27, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7899), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7906), "C:\\somewhere\\", -23 },
                    { -28, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7914), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7921), "D:\\somewhere\\", -23 },
                    { -29, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7930), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7937), "1GB", -24 },
                    { -22, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7820), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7827), "e.g. Web02", -20 },
                    { -30, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7944), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7951), "Physical", -24 },
                    { -32, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7974), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7981), "e.g. www.mysite.com", -26 },
                    { -33, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7989), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7996), "Wildcard", -26 },
                    { -34, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8003), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8010), "single", -26 },
                    { -35, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8018), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8025), "Web01 C:\\somewhere\\", -27 },
                    { -36, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8033), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8040), "Web02 D:\\somewhere\\", -27 },
                    { -37, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8048), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8055), "e.g. www.mysite.com", -28 },
                    { -38, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8063), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8070), "e.g. my.app.com", -28 },
                    { -31, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7959), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7966), "e.g. *.mysite.com", -25 },
                    { -21, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7805), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7812), "e.g. db1", -20 },
                    { -20, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7789), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7796), "Hyper-Visor", -19 },
                    { -19, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7772), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7779), "VM", -19 },
                    { -2, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7446), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7476), "e.g. AppSI", -15 },
                    { -3, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7521), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7529), "e.g. Web01", -15 },
                    { -4, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7537), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7544), "e.g. DC4", -15 },
                    { -5, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7552), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7559), "Database", -16 },
                    { -6, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7568), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7575), "Application", -16 },
                    { -7, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7584), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7591), "Web", -16 },
                    { -8, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7600), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7607), "Other", -16 },
                    { -9, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7616), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7624), "Windows 2016", -17 },
                    { -10, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7632), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7639), "CentOS v7.2", -17 },
                    { -11, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7647), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7654), "Redhat v7.0", -17 },
                    { -12, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7662), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7669), "Windows 2016 DC", -17 },
                    { -13, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7678), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7685), "500GB C:", -18 },
                    { -14, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7694), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7701), "700GB's each C: &amp; D: ", -18 },
                    { -15, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7709), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7716), "1TB F:", -18 },
                    { -16, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7724), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7731), "2TB each P: &amp; Z:", -18 },
                    { -17, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7741), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7748), "VM", -19 },
                    { -18, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7756), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(7763), "Physical", -19 },
                    { -39, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8078), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8085), "Web01 C:\\somewhere\\", -29 },
                    { -40, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8093), true, "Anonymous", new DateTime(2020, 6, 13, 21, 49, 27, 891, DateTimeKind.Local).AddTicks(8100), "Web01 D:\\somewhere\\", -29 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveys_ClientId",
                table: "ClientSurveys",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveys_SurveyId",
                table: "ClientSurveys",
                column: "SurveyId");

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
                name: "IX_Surveys_SuveryId_Version",
                table: "Surveys",
                columns: new[] { "SuveryId", "Version" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SurveyStep_SurveyId_SurveyVersion",
                table: "SurveyStep",
                columns: new[] { "SurveyId", "SurveyVersion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientSurveys");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "Clients");

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
        }
    }
}
