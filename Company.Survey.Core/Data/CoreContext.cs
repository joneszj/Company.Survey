using Company.Survey.Core.Data.Entities;
using Company.Survey.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace Company.Survey.Core.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            const int Version = 8;
            const string CompanyName = "Databerry";
            modelBuilder.Entity<Entities.Survey>().HasData(new Entities.Survey
            {
                CompanyName = CompanyName,
                CompanySite = "www.databerry.com",
                ContactTitle = "Phone",
                ContactPhone = "855-350-0707",
                Version = Version,
                Title = $"Infrastructure Migration Survey Form V{Version}",
                DateOfQuestionnaire = DateTime.Today,
                SurveySteps = new SurveyStep[]
                {
                    new SurveyStep {
                        StepContent = new StepContent
                        {
                            Title = $"{CompanyName} Migration Process:",
                            ContentBlocks = new [] { @"<img src=\""/images/databerrymigrationprocess.jpg\"" alt=\""migration process\"">" }
                        },
                        Title = "Organization/Company &amp; Primary Contact Details: Step A",
                        Order = 0
                    },
                    new SurveyStep {
                        Title = "Source Migration Infrastructure Details: Step B",
                        Order = 1,
                        Questions = new SurveyQuestion[]
                        {
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Current Hosting Service Provider?",
                                Note = "(e.g. Amazon AWS, Azure, On-Premise)",
                                Order = 0
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total count of Server(s)?",
                                Note = string.Empty,
                                Order = 2
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Is there a SAN? (Yes or No)",
                                Note = string.Empty,
                                Order = 3
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total Count of Database(s)?",
                                Note = string.Empty,
                                Order = 5
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions &amp; Names ?",
                                Note = "(e.g. .NET 4.5 | PHP 5.4 | Java 1.5)",
                                Order = 6
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any Third-party commercial applications or platforms | API’s | Plug-ins?",
                                Note = "(e.g. Joomla 2.x, Drupal 7.2, WordPress 4.1, QuickBooks v18.0 etc.)",
                                Order = 6
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Active Directory Migration (Yes or No)?",
                                Note = "(Note: VPN will be required if migrating over WAN)",
                                Order = 7
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any Mobile Apps?",
                                Note = "(e.g. iOS Apple swift, Android java, Windows Mobile)",
                                Order = 8
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any E-commerce or Payment Gateways Service/platforms involved?",
                                Note = "(e.g. Authorize.net, PayPal, Stripe, Magento etc.)",
                                Order = 9
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total SSL Certificate(s)?",
                                Order = 11
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Is there any Server Control Panels installed?",
                                Note = "(e.g. Webmin v1.89, Plesk v12.5, CPanel v58, Docker v17.x)",
                                Order = 12
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "List existing Web Server platform &amp; Versions?",
                                Note = "(e.g. IIS 7.0, Apache 2.2, Nginx 1.1)",
                                Order = 14
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Are there any E-mail platforms or services installed on the Server(s) Type | Version?",
                                Note = "(e.g. Sendmail v8.7, PHPmailer, Postfix, MS Exchange v2013, Exim)",
                                Order = 14
                            },
                            new SurveyQuestion
                            {
                                ReplyType = QuestionReplyTypes.Text,
                                Quesiton = "Total Monthly estimated average of Usage Traffic and/or Transactions volume?",
                                Note = "(e.g. Google analytics data and/or Environment estimated usage of High, Medium, Low)",
                                Order = 15
                            },
                        },
                        QuestionGroups = new SurveyQuestionGroup[]
                        {
                            new SurveyQuestionGroup
                            {
                                Title = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                                Order = 1,
                                SurveyGroupQuestions = new SurveyQuestion[]
                                {
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Name of Server",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 0,
                                        PossibleReplies = new []
                                        {
                                            "e.g. db1",
                                            "e.g. AppSI",
                                            "e.g. Web01",
                                            "e.g. DC4"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Describe the Type of Server",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 1,
                                        PossibleReplies = new []
                                        {
                                            "Database",
                                            "Application",
                                            "Web",
                                            "Other"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "OS Type & Version",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 2,
                                        PossibleReplies = new []
                                        {
                                            "Windows 2016",
                                            "CentOS v7.2",
                                            "Redhat v7.0",
                                            "Windows 2016 DC"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Total Storage of Server in (GB'S TB'S) & amp; Partitions",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 3,
                                        PossibleReplies = new []
                                        {
                                            "500GB C:",
                                            "700GB's each C: &amp; D: ",
                                            "1TB F:",
                                            "2TB each P: &amp; Z:"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 4,
                                        PossibleReplies = new []
                                        {
                                            "VM",
                                            "Physical",
                                            "VM",
                                            "Hyper-Visor"
                                        }
                                    }
                                }
                            },
                            new SurveyQuestionGroup
                            {
                                Title = "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?",
                                Order = 4,
                                ExampleReplies = "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)",
                                SurveyGroupQuestions = new SurveyQuestion[]
                                {
                                    new SurveyQuestion
                                    {
                                        Quesiton = "DB Server Name",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 0,
                                        PossibleReplies = new []
                                        {
                                            "e.g. db1",
                                            "e.g. Web02"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "DB Engine Type &amp; Version",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 1,
                                        PossibleReplies = new []
                                        {
                                            "MS SQL 2012",
                                            "MySQL"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "DB Name",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 2,
                                        PossibleReplies = new []
                                        {
                                            "Sales_DB",
                                            "Support_DB",
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "DB Location",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 3,
                                        PossibleReplies = new []
                                        {
                                            @"C:\somewhere\",
                                            @"D:\somewhere\"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Total DB Size in (MB's GB'S TB'S)",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 4,
                                        PossibleReplies = new []
                                        {
                                            "1GB",
                                            "Physical",
                                        }
                                    }
                                }
                            },
                            new SurveyQuestionGroup
                            {
                                Title = "Are there any SSL certificate(s) installed (Type &amp; Location If possible)?",
                                Order = 10,
                                ExampleReplies = "(if Yes please List)",
                                SurveyGroupQuestions = new SurveyQuestion[]
                                {
                                    new SurveyQuestion
                                    {
                                        ReplyType = QuestionReplyTypes.Text,
                                        Quesiton = "SSL Name",
                                        Order = 0,
                                        PossibleReplies = new [] 
                                        {
                                            "e.g. *.mysite.com",
                                            "e.g. www.mysite.com",
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        ReplyType = QuestionReplyTypes.Text,
                                        Quesiton = "SSL Type",
                                        Order = 1,
                                        PossibleReplies = new []
                                        {
                                            "Wildcard",
                                            "single",
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        ReplyType = QuestionReplyTypes.Text,
                                        Quesiton = "SSL Location (Server Name/Location)",
                                        Order = 2,
                                        PossibleReplies = new []
                                        {
                                            @"Web01 C:\somewhere\",
                                            @"Web02 D:\somewhere\",
                                        }
                                    }
                                }
                            },
                            new SurveyQuestionGroup 
                            {
                                Title = "List the number of Website Names (&amp; Location on Servers if possible)?",
                                Order = 13,
                                SurveyGroupQuestions = new SurveyQuestion[] 
                                {
                                    new SurveyQuestion 
                                    {
                                        Quesiton = "Website Name",
                                        Order = 0,
                                        PossibleReplies = new []
                                        {
                                            "e.g. www.mysite.com",
                                            "e.g. my.app.com"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Website Location (Server Name/Location)",
                                        Order = 1,
                                        PossibleReplies = new []
                                        {
                                            @"Web01 C:\somewhere\",
                                            @"Web01 D:\somewhere\"
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new SurveyStep {
                        Title = "Destination Migration Infrastructure Details: Step C",
                        Order = 2,
                        Questions = new SurveyQuestion[]
                        {
                            new SurveyQuestion
                            {
                                Quesiton = "Moving to Hosting Service Provider?",
                                Note = "(e.g. Amazon AWS, Azure, On-Premise)",
                                Order = 0,
                            },
                            new SurveyQuestion
                            {
                                Quesiton = "Is there a SAN? (Yes or No)",
                                Order = 2,
                            },
                            new SurveyQuestion
                            {
                                Quesiton = "Specify the Type of Migration?",
                                Note = "(e.g. P= Physical V=Virtual P-P, P-V, V-V, V-P)",
                                Order = 3,
                            },
                            new SurveyQuestion
                            {
                                Quesiton = "Please include any additional technical details that you may feel is important that was not covered above:",
                                Order = 4,
                            },
                        },
                        QuestionGroups = new SurveyQuestionGroup[]
                        {
                            new SurveyQuestionGroup
                            {
                                Title = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                                Order = 1,
                                SurveyGroupQuestions = new SurveyQuestion[]
                                {
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Name of Server",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 0,
                                        PossibleReplies = new []
                                        {
                                            "e.g. db1",
                                            "e.g. AppSI",
                                            "e.g. Web01",
                                            "e.g. DC4"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Describe the Type of Server",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 1,
                                        PossibleReplies = new []
                                        {
                                            "Database",
                                            "Application",
                                            "Web",
                                            "Other"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "OS Type & Version",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 2,
                                        PossibleReplies = new []
                                        {
                                            "Windows 2016",
                                            "CentOS v7.2",
                                            "Redhat v7.0",
                                            "Windows 2016 DC"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "Total Storage of Server in (GB'S TB'S) & amp; Partitions",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 3,
                                        PossibleReplies = new []
                                        {
                                            "500GB C:",
                                            "700GB's each C: &amp; D: ",
                                            "1TB F:",
                                            "2TB each P: &amp; Z:"
                                        }
                                    },
                                    new SurveyQuestion
                                    {
                                        Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                                        ReplyType = QuestionReplyTypes.Text,
                                        Order = 4,
                                        PossibleReplies = new []
                                        {
                                            "VM",
                                            "Physical",
                                            "VM",
                                            "Hyper-Visor"
                                        }
                                    }
                                }
                            },
                        }
                    }
                }
            });
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Entities.Survey> Surveys { get; set; }
    }
}
