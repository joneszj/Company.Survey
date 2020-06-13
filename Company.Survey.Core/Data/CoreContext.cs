using Company.Survey.Core.Data.Entities;
using Company.Survey.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Company.Survey.Core.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region value conversion
            modelBuilder
                .Entity<SurveyQuestion>()
                .Property(e => e.ReplyType)
                .HasConversion(
                    v => v.ToString(),
                    v => (QuestionReplyTypes)Enum.Parse(typeof(QuestionReplyTypes), v));
            #endregion

            #region db seed
            const int Version = 8;
            const string CompanyName = "Databerry";

            modelBuilder.Entity<Entities.Survey>().HasKey(e => new { e.Id, e.Version });
            modelBuilder.Entity<Entities.Survey>().HasData(new Entities.Survey
            {
                // seed does not recognize identity when set on property so we must set it manually
                // ef core recomends negative values to prevent conflict of seeded and non-seeded data
                Id = -1,
                CompanyName = CompanyName,
                CompanySite = "www.databerry.com",
                ContactTitle = "Phone",
                ContactPhone = "855-350-0707",
                Version = Version,
                Title = $"Infrastructure Migration Survey Form V{Version}",
                DateOfQuestionnaire = DateTime.Today,
            });
            modelBuilder.Entity<SurveyStep>().HasData(new SurveyStep[]
            {
                    new SurveyStep {
                        Id = -1,
                        SurveyId = -1,
                        Title = "Organization/Company &amp; Primary Contact Details: Step A",
                        Order = 0
                    },
                    new SurveyStep {
                        Id = -2,
                        SurveyId = -1,
                        Title = "Source Migration Infrastructure Details: Step B",
                        Order = 1
                    },
                    new SurveyStep {
                        Id = -3,
                        SurveyId = -1,
                        Title = "Destination Migration Infrastructure Details: Step C",
                        Order = 2
                    }
            });
            modelBuilder.Entity<StepContent>().HasData(new StepContent
            {
                Id = -1,
                SurveyStepId = -1,
                Title = $"{CompanyName} Migration Process:"
            });
            modelBuilder.Entity<Content>().HasData(new Content
            {
                Id = -1,
                StepContentId = -1,
                ContentData = @"<img src=\""/images/databerrymigrationprocess.jpg\"" alt=\""migration process\"">"
            });
            modelBuilder.Entity<SurveyQuestionGroup>().HasData(new SurveyQuestionGroup[]
                        {
                            new SurveyQuestionGroup
                            {
                                Id = -1,
                                SurveyStepId = -2,
                                Title = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                                Order = 1
                            },
                            new SurveyQuestionGroup
                            {
                                Id = -2,
                                SurveyStepId = -2,
                                Title = "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?",
                                Order = 4,
                                Note = "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)",
                            },
                            new SurveyQuestionGroup
                            {
                                Id = -3,
                                SurveyStepId = -2,
                                Title = "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?",
                                Order = 10,
                                Note = "(if Yes please List)"
                            },
                            new SurveyQuestionGroup
                            {
                                Id = -4,
                                SurveyStepId = -2,
                                Title = "List the number of Website Names (&amp; Location on Servers if possible)?",
                                Order = 13
                            }
                        });
            modelBuilder.Entity<SurveyQuestionGroup>().HasData(new SurveyQuestionGroup[]
                        {
                            new SurveyQuestionGroup
                            {
                                Id = -5,
                                SurveyStepId = -3,
                                Title = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                                Order = 1
                            }
                        });
            modelBuilder.Entity<SurveyQuestion>().HasData(new SurveyQuestion[]
                        {
                            new SurveyQuestion
                            {
                                Id = -1,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Current Hosting Service Provider?",
                                Note = "(e.g. Amazon AWS, Azure, On-Premise)",
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                Id = -2,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total count of Server(s)?",
                                Note = string.Empty,
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                Id = -3,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Is there a SAN? (Yes or No)",
                                Note = string.Empty,
                                Order = 3
                            },
                            new SurveyQuestion
                            {
                                Id = -4,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total Count of Database(s)?",
                                Note = string.Empty,
                                Order = 5
                            },
                            new SurveyQuestion
                            {
                                Id = -5,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?",
                                Note = "(e.g. .NET 4.5 | PHP 5.4 | Java 1.5)",
                                Order = 6
                            },
                            new SurveyQuestion
                            {
                                Id = -6,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any Third-party commercial applications or platforms | API’s | Plug-ins?",
                                Note = "(e.g. Joomla 2.x, Drupal 7.2, WordPress 4.1, QuickBooks v18.0 etc.)",
                                Order = 6
                            },
                            new SurveyQuestion
                            {
                                Id = -7,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Active Directory Migration (Yes or No)?",
                                Note = "(Note: VPN will be required if migrating over WAN)",
                                Order = 7
                            },
                            new SurveyQuestion
                            {
                                Id = -8,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any Mobile Apps?",
                                Note = "(e.g. iOS Apple swift, Android java, Windows Mobile)",
                                Order = 8
                            },
                            new SurveyQuestion
                            {
                                Id = -9,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any E-commerce or Payment Gateways Service/platforms involved?",
                                Note = "(e.g. Authorize.net, PayPal, Stripe, Magento etc.)",
                                Order = 9
                            },
                            new SurveyQuestion
                            {
                                Id = -10,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total SSL Certificate(s)?",
                                Order = 11
                            },
                            new SurveyQuestion
                            {
                                Id = -11,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Is there any Server Control Panels installed?",
                                Note = "(e.g. Webmin v1.89, Plesk v12.5, CPanel v58, Docker v17.x)",
                                Order = 12
                            },
                            new SurveyQuestion
                            {
                                Id = -12,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "List existing Web Server platform &amp; Versions?",
                                Note = "(e.g. IIS 7.0, Apache 2.2, Nginx 1.1)",
                                Order = 14
                            },
                            new SurveyQuestion
                            {
                                Id = -13,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any E-mail platforms or services installed on the Server(s) Type | Version?",
                                Note = "(e.g. Sendmail v8.7, PHPmailer, Postfix, MS Exchange v2013, Exim)",
                                Order = 14
                            },
                            new SurveyQuestion
                            {
                                Id = -14,
                                SurveyStepId = -2,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total Monthly estimated average of Usage Traffic and/or Transactions volume?",
                                Note = "(e.g. Google analytics data and/or Environment estimated usage of High, Medium, Low)",
                                Order = 15
                            },
                            new SurveyQuestion
                            {
                                Id = -15,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -1,
                                Quesiton = "Name of Server",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                Id = -16,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -1,
                                Quesiton = "Describe the Type of Server",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 1,
                            },
                            new SurveyQuestion
                            {
                                Id = -17,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -1,
                                Quesiton = "OS Type & Version",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                Id = -18,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -1,
                                Quesiton = "Total Storage of Server in (GB'S TB'S) & amp; Partitions",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 3
                            },
                            new SurveyQuestion
                            {
                                Id = -19,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -1,
                                Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 4
                            },
                            new SurveyQuestion
                            {
                                Id = -20,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -2,
                                Quesiton = "DB Server Name",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                Id = -21,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -2,
                                Quesiton = "DB Engine Type &amp; Version",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 1
                            },
                            new SurveyQuestion
                            {
                                Id = -22,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -2,
                                Quesiton = "DB Name",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                Id = -23,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -2,
                                Quesiton = "DB Location",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 3
                            },
                            new SurveyQuestion
                            {
                                Id = -24,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -2,
                                Quesiton = "Total DB Size in (MB's GB'S TB'S)",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 4
                            },
                            new SurveyQuestion
                            {
                                Id = -25,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -3,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "SSL Name",
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                Id = -26,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -3,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "SSL Type",
                                Order = 1
                            },
                            new SurveyQuestion
                            {
                                Id = -27,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -3,
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "SSL Location (Server Name/Location)",
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                Id = -28,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -4,
                                Quesiton = "Website Name",
                                Order = 0,
                            },
                            new SurveyQuestion
                            {
                                Id = -29,
                                SurveyStepId = -2,
                                SurveyQuestionGroupID = -4,
                                Quesiton = "Website Location (Server Name/Location)",
                                Order = 1
                            },
                            new SurveyQuestion
                            {
                                Id = -30,
                                SurveyStepId = -3,
                                Quesiton = "Name of Server",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                Id = -31,
                                SurveyStepId = -3,
                                Quesiton = "Describe the Type of Server",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 1
                            },
                            new SurveyQuestion
                            {
                                Id = -32,
                                SurveyStepId = -3,
                                Quesiton = "OS Type & Version",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                Id = -33,
                                SurveyStepId = -3,
                                Quesiton = "Total Storage of Server in (GB'S TB'S) & amp; Partitions",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 3
                            },
                            new SurveyQuestion
                            {
                                Id = -34,
                                SurveyStepId = -3,
                                Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                                ReplyType = QuestionReplyTypes.Text,
                                Order = 4
                            },
                            new SurveyQuestion
                            {
                                Id = -35,
                                SurveyStepId = -3,
                                Quesiton = "Moving to Hosting Service Provider?",
                                Note = "(e.g. Amazon AWS, Azure, On-Premise)",
                                Order = 0,
                            },
                            new SurveyQuestion
                            {
                                Id = -36,
                                SurveyStepId = -3,
                                Quesiton = "Is there a SAN? (Yes or No)",
                                Order = 2,
                            },
                            new SurveyQuestion
                            {
                                Id = -37,
                                SurveyStepId = -3,
                                Quesiton = "Specify the Type of Migration?",
                                Note = "(e.g. P= Physical V=Virtual P-P, P-V, V-V, V-P)",
                                Order = 3,
                            },
                            new SurveyQuestion
                            {
                                Id = -38,
                                SurveyStepId = -3,
                                Quesiton = "Please include any additional technical details that you may feel is important that was not covered above:",
                                Order = 4,
                            }
                        });
            modelBuilder.Entity<Reply>().HasData(new[]
            {
                new Reply {
                    Id = -1,
                    SurveyQuestionId = -15,
                    ReplyData = "e.g. db1" },
                new Reply {
                    Id = -2,
                    SurveyQuestionId = -15,
                    ReplyData = "e.g. AppSI" },
                new Reply {
                    Id = -3,
                    SurveyQuestionId = -15,
                    ReplyData = "e.g. Web01" },
                new Reply {
                    Id = -4,
                    SurveyQuestionId = -15,
                    ReplyData = "e.g. DC4" },
                new Reply {
                    Id = -5,
                    SurveyQuestionId = -16,
                    ReplyData = "Database", },
                new Reply {
                    Id = -6,
                    SurveyQuestionId = -16,
                    ReplyData = "Application" },
                new Reply {
                    Id = -7,
                    SurveyQuestionId = -16,
                    ReplyData = "Web" },
                new Reply {
                    Id = -8,
                    SurveyQuestionId = -16,
                    ReplyData = "Other" },
                new Reply {
                    Id = -9,
                    SurveyQuestionId = -17,
                    ReplyData = "Windows 2016" },
                new Reply {
                    Id = -10,
                    SurveyQuestionId = -17,
                    ReplyData = "CentOS v7.2" },
                new Reply {
                    Id = -11,
                    SurveyQuestionId = -17,
                    ReplyData = "Redhat v7.0" },
                new Reply {
                    Id = -12,
                    SurveyQuestionId = -17,
                    ReplyData = "Windows 2016 DC" },
                new Reply {
                    Id = -13,
                    SurveyQuestionId = -18,
                    ReplyData = "500GB C:" },
                new Reply {
                    Id = -14,
                    SurveyQuestionId = -18,
                    ReplyData = "700GB's each C: &amp; D: " },
                new Reply {
                    Id = -15,
                    SurveyQuestionId = -18,
                    ReplyData = "1TB F:" },
                new Reply {
                    Id = -16,
                    SurveyQuestionId = -18,
                    ReplyData = "2TB each P: &amp; Z:" },
                new Reply {
                    Id = -17,
                    SurveyQuestionId = -19,
                    ReplyData = "VM" },
                new Reply {
                    Id = -18,
                    SurveyQuestionId = -19,
                    ReplyData = "Physical" },
                new Reply {
                    Id = -19,
                    SurveyQuestionId = -19,
                    ReplyData = "VM" },
                new Reply {
                    Id = -20,
                    SurveyQuestionId = -19,
                    ReplyData = "Hyper-Visor" },
                new Reply {
                    Id = -21,
                    SurveyQuestionId = -20,
                    ReplyData = "e.g. db1" },
                new Reply {
                    Id = -22,
                    SurveyQuestionId = -20,
                    ReplyData = "e.g. Web02" },
                new Reply {
                    Id = -23,
                    SurveyQuestionId = -21,
                    ReplyData = "MS SQL 2012" },
                new Reply {
                    Id = -24,
                    SurveyQuestionId = -21,
                    ReplyData = "MySQL" },
                new Reply {
                    Id = -25,
                    SurveyQuestionId = -22,
                    ReplyData = "Sales_DB" },
                new Reply {
                    Id = -26,
                    SurveyQuestionId = -22,
                    ReplyData = "Support_DB" },
                new Reply {
                    Id = -27,
                    SurveyQuestionId = -23,
                    ReplyData = @"C:\somewhere\" },
                new Reply {
                    Id = -28,
                    SurveyQuestionId = -23,
                    ReplyData = @"D:\somewhere\" },
                new Reply {
                    Id = -29,
                    SurveyQuestionId = -24,
                    ReplyData = "1GB" },
                new Reply {
                    Id = -30,
                    SurveyQuestionId = -24,
                    ReplyData = "Physical" },
                new Reply {
                    Id = -31,
                    SurveyQuestionId = -25,
                    ReplyData = "e.g. *.mysite.com" },
                new Reply {
                    Id = -32,
                    SurveyQuestionId = -26,
                    ReplyData = "e.g. www.mysite.com" },
                new Reply {
                    Id = -33,
                    SurveyQuestionId = -26,
                    ReplyData = "Wildcard" },
                new Reply {
                    Id = -34,
                    SurveyQuestionId = -26,
                    ReplyData = "single" },
                new Reply {
                    Id = -35,
                    SurveyQuestionId = -27,
                    ReplyData = @"Web01 C:\somewhere\" },
                new Reply {
                    Id = -36,
                    SurveyQuestionId = -27,
                    ReplyData = @"Web02 D:\somewhere\" },
                new Reply {
                    Id = -37,
                    SurveyQuestionId = -28,
                    ReplyData = "e.g. www.mysite.com" },
                new Reply {
                    Id = -38,
                    SurveyQuestionId = -28,
                    ReplyData = "e.g. my.app.com" },
                new Reply {
                    Id = -39,
                    SurveyQuestionId = -29,
                    ReplyData = @"Web01 C:\somewhere\" },
                new Reply {
                    Id = -40,
                    SurveyQuestionId = -29,
                    ReplyData = @"Web01 D:\somewhere\" },
                new Reply {
                    Id = -41,
                    SurveyQuestionId = -30,
                    ReplyData = "e.g. db1" },
                new Reply {
                    Id = -42,
                    SurveyQuestionId = -30,
                    ReplyData = "e.g. AppSI" },
                new Reply {
                    Id = -43,
                    SurveyQuestionId = -30,
                    ReplyData = "e.g. Web01" },
                new Reply {
                    Id = -44,
                    SurveyQuestionId = -30,
                    ReplyData = "e.g. DC4" },
                new Reply {
                    Id = -45,
                    SurveyQuestionId = -31,
                    ReplyData = "Database" },
                new Reply {
                    Id = -46,
                    SurveyQuestionId = -31,
                    ReplyData = "Application" },
                new Reply {
                    Id = -47,
                    SurveyQuestionId = -31,
                    ReplyData = "Web" },
                new Reply {
                    Id = -48,
                    SurveyQuestionId = -31,
                    ReplyData = "Other" },
                new Reply {
                    Id = -49,
                    SurveyQuestionId = -32,
                    ReplyData = "Windows 2016" },
                new Reply {
                    Id = -50,
                    SurveyQuestionId = -32,
                    ReplyData = "CentOS v7.2" },
                new Reply {
                    Id = -51,
                    SurveyQuestionId = -32,
                    ReplyData = "Redhat v7.0" },
                new Reply {
                    Id = -52,
                    SurveyQuestionId = -32,
                    ReplyData = "Windows 2016 DC" },
                new Reply {
                    Id = -53,
                    SurveyQuestionId = -33,
                    ReplyData = "500GB C:" },
                new Reply {
                    Id = -55,
                    SurveyQuestionId = -33,
                    ReplyData = "700GB's each C: &amp; D:" },
                new Reply {
                    Id = -56,
                    SurveyQuestionId = -33,
                    ReplyData = "1TB F:" },
                new Reply {
                    Id = -57,
                    SurveyQuestionId = -33,
                    ReplyData = "2TB each P: &amp; Z:" },
                new Reply {
                    Id = -58,
                    SurveyQuestionId = -34,
                    ReplyData = "VM" },
                new Reply {
                    Id = -59,
                    SurveyQuestionId = -34,
                    ReplyData = "Physical" },
                new Reply {
                    Id = -60,
                    SurveyQuestionId = -34,
                    ReplyData = "VM" },
                new Reply {
                    Id = -61,
                    SurveyQuestionId = -34,
                    ReplyData = "Hyper-Visor" }
            });
            #endregion
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Entities.Survey> Surveys { get; set; }
    }
}
