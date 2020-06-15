using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Survey.Core.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SuveryId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanySite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfQuestionnaire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ClientSurveyKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    RequestedStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestedEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    SurveyVersion = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyStepId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyStepId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ContentData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepContentId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Quesiton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ReplyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyStepId = table.Column<int>(type: "int", nullable: false),
                    SurveyQuestionGroupID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.Id);
                    table.CheckConstraint("CK_SurveyQuestion_ReplyType_Enum_Constraint", "[ReplyType] IN(N'Text', N'TextArea', N'Multiple', N'Select')");
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ReplyData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyQuestionId = table.Column<int>(type: "int", nullable: false),
                    ClientSurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reply_ClientSurveys_ClientSurveyId",
                        column: x => x.ClientSurveyId,
                        principalTable: "ClientSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reply_SurveyQuestion_SurveyQuestionId",
                        column: x => x.SurveyQuestionId,
                        principalTable: "SurveyQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "Phone" },
                values: new object[] { -1, "Test Company", "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 811, DateTimeKind.Local).AddTicks(7265), "joneszj@gmail.com", "Zachary", true, "Jones", "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 811, DateTimeKind.Local).AddTicks(7287), "555-333-1111" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "CompanyName", "CompanySite", "ContactPhone", "ContactTitle", "CreatedBy", "CreatedDate", "DateOfQuestionnaire", "IsActive", "ModifiedBy", "ModifiedDate", "SuveryId", "Title", "Version" },
                values: new object[] { -1, "Databerry", "www.databerry.com", "855-350-0707", "Phone", "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 807, DateTimeKind.Local).AddTicks(1652), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 809, DateTimeKind.Local).AddTicks(8762), -1, "Infrastructure Migration Survey Form V8", 8 });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -1, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(535), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(552), 0, -1, 8, "Organization/Company &amp; Primary Contact Details: Step A" });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -2, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2644), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2660), 1, -1, 8, "Source Migration Infrastructure Details: Step B" });

            migrationBuilder.InsertData(
                table: "SurveyStep",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Order", "SurveyId", "SurveyVersion", "Title" },
                values: new object[] { -3, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2695), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(2698), 2, -1, 8, "Destination Migration Infrastructure Details: Step C" });

            migrationBuilder.InsertData(
                table: "StepContent",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "SurveyStepId", "Title" },
                values: new object[] { -1, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(3475), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(3488), -1, "Databerry Migration Process:" });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -37, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2757), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2760), "(e.g. P= Physical V=Virtual P-P, P-V, V-V, V-P)", 3, "Specify the Type of Migration?", "Text", null, -3 },
                    { -36, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2751), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2754), null, 2, "Is there a SAN? (Yes or No)", "Text", null, -3 },
                    { -35, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2744), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2747), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Moving to Hosting Service Provider?", "Text", null, -3 },
                    { -14, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1974), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1977), "(e.g. Google analytics data and/or Environment estimated usage of High, Medium, Low)", 15, "Total Monthly estimated average of Usage Traffic and/or Transactions volume?", "Text", null, -2 },
                    { -13, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1967), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1970), "(e.g. Sendmail v8.7, PHPmailer, Postfix, MS Exchange v2013, Exim)", 14, "Are there any E-mail platforms or services installed on the Server(s) Type | Version?", "Text", null, -2 },
                    { -12, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1960), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1963), "(e.g. IIS 7.0, Apache 2.2, Nginx 1.1)", 14, "List existing Web Server platform &amp; Versions?", "Text", null, -2 },
                    { -38, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2764), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2767), null, 4, "Please include any additional technical details that you may feel is important that was not covered above:", "TextArea", null, -3 },
                    { -10, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1947), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1950), null, 11, "Total SSL Certificate(s)?", "Text", null, -2 },
                    { -11, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1953), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1957), "(e.g. Webmin v1.89, Plesk v12.5, CPanel v58, Docker v17.x)", 12, "Is there any Server Control Panels installed?", "Text", null, -2 },
                    { -8, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1933), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1937), "(e.g. iOS Apple swift, Android java, Windows Mobile)", 8, "Are there any Mobile Apps?", "Text", null, -2 },
                    { -7, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1925), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1928), "(Note: VPN will be required if migrating over WAN)", 7, "Active Directory Migration (Yes or No)?", "Text", null, -2 },
                    { -6, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1918), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1921), "(e.g. Joomla 2.x, Drupal 7.2, WordPress 4.1, QuickBooks v18.0 etc.)", 6, "Are there any Third-party commercial applications or platforms | API’s | Plug-ins?", "Text", null, -2 },
                    { -5, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1911), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1914), "(e.g. .NET 4.5 | PHP 5.4 | Java 1.5)", 6, "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?", "Text", null, -2 },
                    { -4, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1904), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1907), "", 5, "Total Count of Database(s)?", "Text", null, -2 },
                    { -3, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1896), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1899), "", 3, "Is there a SAN? (Yes or No)", "Text", null, -2 },
                    { -2, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1826), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1840), "", 2, "Total count of Server(s)?", "Text", null, -2 },
                    { -1, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(9532), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(9545), "(e.g. Amazon AWS, Azure, On-Premise)", 0, "Current Hosting Service Provider?", "Text", null, -2 },
                    { -9, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1940), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1943), "(e.g. Authorize.net, PayPal, Stripe, Magento etc.)", 9, "Are there any E-commerce or Payment Gateways Service/platforms involved?", "Text", null, -2 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestionGroup",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "SurveyStepId", "Title" },
                values: new object[,]
                {
                    { -1, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(6819), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(6834), null, 1, -2, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" },
                    { -2, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8218), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8232), "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)", 4, -2, "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?" },
                    { -3, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8734), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8746), "(if Yes please List)", 10, -2, "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?" },
                    { -4, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8767), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8770), null, 13, -2, "List the number of Website Names (&amp; Location on Servers if possible)?" },
                    { -5, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8774), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(8777), null, 1, -3, "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "ContentData", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "StepContentId" },
                values: new object[] { -1, "<img src=\\\"/images/databerrymigrationprocess.jpg\\\" alt=\\\"migration process\\\">", "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(5134), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 812, DateTimeKind.Local).AddTicks(5149), -1 });

            migrationBuilder.InsertData(
                table: "SurveyQuestion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Note", "Order", "Quesiton", "ReplyType", "SurveyQuestionGroupID", "SurveyStepId" },
                values: new object[,]
                {
                    { -32, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2724), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2727), null, 2, "OS Type & Version", "Text", -5, -3 },
                    { -31, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2717), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2720), null, 1, "Describe the Type of Server", "Text", -5, -3 },
                    { -30, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2710), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2713), null, 0, "Name of Server", "Text", -5, -3 },
                    { -29, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2704), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2707), null, 1, "Website Location (Server Name/Location)", "Text", -4, -2 },
                    { -28, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2697), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2700), null, 0, "Website Name", "Text", -4, -2 },
                    { -27, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2690), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2693), null, 2, "SSL Location (Server Name/Location)", "Text", -3, -2 },
                    { -26, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2683), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2686), null, 1, "SSL Type", "Text", -3, -2 },
                    { -25, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2677), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2680), null, 0, "SSL Name", "Text", -3, -2 },
                    { -33, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2731), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2734), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", -5, -3 },
                    { -24, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2670), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2673), null, 4, "Total DB Size in (MB's GB'S TB'S)", "Text", -2, -2 },
                    { -22, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2657), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2660), null, 2, "DB Name", "Text", -2, -2 },
                    { -21, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2648), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2652), null, 1, "DB Engine Type &amp; Version", "Text", -2, -2 },
                    { -20, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2593), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2596), null, 0, "DB Server Name", "Text", -2, -2 },
                    { -19, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2586), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2589), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", -1, -2 },
                    { -18, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2579), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2582), null, 3, "Total Storage of Server in (GB'S TB'S) & amp; Partitions", "Text", -1, -2 },
                    { -17, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2572), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2575), null, 2, "OS Type & Version", "Text", -1, -2 },
                    { -16, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2539), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2552), null, 1, "Describe the Type of Server", "Text", -1, -2 },
                    { -15, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1980), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(1983), null, 0, "Name of Server", "Text", -1, -2 },
                    { -23, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2663), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2666), null, 3, "DB Location", "Text", -2, -2 },
                    { -34, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2737), true, "Anonymous", new DateTime(2020, 6, 15, 10, 18, 59, 813, DateTimeKind.Local).AddTicks(2741), null, 4, "State of Server (Physical, Virtual, Hyper-Visor)", "Text", -5, -3 }
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
                name: "IX_Reply_ClientSurveyId",
                table: "Reply",
                column: "ClientSurveyId");

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
                name: "Content");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "StepContent");

            migrationBuilder.DropTable(
                name: "ClientSurveys");

            migrationBuilder.DropTable(
                name: "SurveyQuestion");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "SurveyQuestionGroup");

            migrationBuilder.DropTable(
                name: "SurveyStep");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
