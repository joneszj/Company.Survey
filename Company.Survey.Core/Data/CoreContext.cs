﻿using Company.Survey.Core.Data.Entities;
using Company.Survey.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Company.Survey.Core.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext() { }
        public CoreContext(DbContextOptions<CoreContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasQueryFilter(p => p.IsActive);
            modelBuilder.Entity<Entities.Survey>().HasQueryFilter(p => p.IsActive);
            modelBuilder.Entity<SurveyQuestion>().HasQueryFilter(p => p.IsActive);
            modelBuilder.Entity<StepContent>().HasQueryFilter(p => p.IsActive);
            modelBuilder.Entity<SurveyStep>().HasQueryFilter(p => p.IsActive);
            modelBuilder.Entity<Content>().HasQueryFilter(p => p.IsActive);

            base.OnModelCreating(modelBuilder);
            BuildValueConversions(modelBuilder);
            BuildMappings(modelBuilder);
            SeedDatabase(modelBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Entities.Survey> Surveys { get; set; }
        public DbSet<ClientSurveys> ClientSurveys { get; set; }
        public DbSet<SurveyStep> SurveySteps { get; set; }
        public DbSet<StepContent> StepContents { get; set; }
        public DbSet<Content> ConbentBlocks { get; set; }
        public DbSet<SurveyQuestion> Questions { get; set; }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var item in markedAsDeleted)
            {
                if (item.Entity is CoreBase entity)
                {
                    if (item.Entity is StepContent)
                    {
                        // TODO: this entitiy should be many to many
                        // because its 1-1 the soft delete fails on inserting new records if one already exists
                        // (fails the fk constraint on stepId)
                        // Instead of another db structure change, I am deleting the record to enable new sections
                        // as the example doesn't indicate a many-many map of stepcontents
                        item.State = EntityState.Deleted;
                    }
                    else
                    {
                        item.State = EntityState.Unchanged;
                        entity.IsActive = false;
                    }
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        #region helpers
        private static void BuildValueConversions(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SurveyQuestion>()
                .Property(e => e.ReplyType)
                .HasConversion(
                    v => v.ToString(),
                    v => (QuestionReplyTypes)Enum.Parse(typeof(QuestionReplyTypes), v));
        }
        private static void BuildMappings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Survey>().HasIndex(e => new { e.Id, e.Version }).IsUnique(true);
            modelBuilder.Entity<SurveyStep>()
                .HasOne(e => e.Survey)
                .WithMany(e => e.SurveySteps)
                .HasPrincipalKey(e => new { e.Id, e.Version })
                .HasForeignKey(e => new { e.SurveyId, e.SurveyVersion });
            modelBuilder.Entity<SurveyQuestion>().HasOne(e=>e.ParentSurveyQuestion).WithMany(e=>e.SurveyQuestions);
            modelBuilder.Entity<Entities.Survey>().HasIndex("SurveyKey", "Version").IsUnique();
        }
        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            const int Version = 8;
            const string CompanyName = "Databerry";
            modelBuilder.Entity<Entities.Survey>().HasData(new Entities.Survey
            {
                // seed does not recognize identity when set on property so we must set it manually
                // ef core recomends negative values to prevent conflict of seeded and non-seeded data
                Id = -1,
                Version = Version,
                CompanyName = CompanyName,
                CompanySite = "www.databerry.com",
                ContactTitle = "Phone",
                ContactPhone = "855-350-0707",
                Title = $"Infrastructure Migration Survey Form",
                DateOfQuestionnaire = DateTime.Today,
                SurveyKey = "Infrastructure Migration"
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = -1,
                Email = "joneszj@gmail.com",
                FirstName = "Zachary",
                LastName = "Jones",
                Phone = "555-333-1111",
                CompanyName = "Test Company"
            });
            modelBuilder.Entity<SurveyStep>().HasData(new SurveyStep[]
            {
                    new SurveyStep {
                        Id = -1,
                        SurveyId = -1,
                        SurveyVersion = Version,
                        Title = "Organization/Company & Primary Contact Details: Step A",
                        Order = 0
                    },
                    new SurveyStep {
                        Id = -2,
                        SurveyId = -1,
                        SurveyVersion = Version,
                        Title = "Source Migration Infrastructure Details: Step B",
                        Order = 1
                    },
                    new SurveyStep {
                        Id = -3,
                        SurveyId = -1,
                        SurveyVersion = Version,
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
                ContentData = @"<img class=""img-fluid"" src=""/assets/images/databerrymigrationprocess.jpg"" alt=""migration process"">"
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
                    Quesiton = "Custom Applications, Applications, Frameworks, | Versions? Please list all Applications types/versions & Names ?",
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
                    Quesiton = "List existing Web Server platform & Versions?",
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
                    ReplyType = QuestionReplyTypes.TextArea,
                    Quesiton = "Please include any additional technical details that you may feel is important that was not covered above:",
                    Order = 4,
                },

                new SurveyQuestion
                {
                    Id = -39,
                    SurveyStepId = -2,
                    Quesiton = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                    Order = 1
                },
                new SurveyQuestion
                {
                    Id = -40,
                    SurveyStepId = -2,
                    Quesiton = "Specify the Database Engine Server(s) Type | Version | Name | Size | Quantity?",
                    Order = 4,
                    Note = "(e.g. Microsoft SQL 2014, MariaDB 5.6, MySQL 5.4, Name of DB, size of DB, MB’s, GB’s, TB’s)",
                },
                new SurveyQuestion
                {
                    Id = -41,
                    SurveyStepId = -2,
                    Quesiton = "Are there any SSL certificate(s) installed (Type & Location If possible)?",
                    Order = 10,
                    Note = "(if Yes please List)"
                },
                new SurveyQuestion
                {
                    Id = -42,
                    SurveyStepId = -2,
                    Quesiton = "List the number of Website Names (& Location on Servers if possible)?",
                    Order = 13
                },
                new SurveyQuestion
                {
                    Id = -43,
                    SurveyStepId = -3,
                    Quesiton = "Specify the number of Source Server(s) to be migrated, Type, OS, Storage, State?",
                    Order = 1
                },
 new SurveyQuestion
                {
                    Id = -15,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -39,
                    Quesiton = "Name of Server",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 0
                },
                new SurveyQuestion
                {
                    Id = -16,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -39,
                    Quesiton = "Describe the Type of Server",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 1,
                },
                new SurveyQuestion
                {
                    Id = -17,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -39,
                    Quesiton = "OS Type & Version",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 2
                },
                new SurveyQuestion
                {
                    Id = -18,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -39,
                    Quesiton = "Total Storage of Server in (GB'S TB'S) & Partitions",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 3
                },
                new SurveyQuestion
                {
                    Id = -19,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -39,
                    Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 4
                },
                new SurveyQuestion
                {
                    Id = -20,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -40,
                    Quesiton = "DB Server Name",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 0
                },
                new SurveyQuestion
                {
                    Id = -21,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -40,
                    Quesiton = "DB Engine Type & Version",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 1
                },
                new SurveyQuestion
                {
                    Id = -22,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -40,
                    Quesiton = "DB Name",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 2
                },
                new SurveyQuestion
                {
                    Id = -23,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -40,
                    Quesiton = "DB Location",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 3
                },
                new SurveyQuestion
                {
                    Id = -24,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -40,
                    Quesiton = "Total DB Size in (MB's GB'S TB'S)",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 4
                },
                new SurveyQuestion
                {
                    Id = -25,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -41,
                    ReplyType = QuestionReplyTypes.Text,
                    Quesiton = "SSL Name",
                    Order = 0
                },
                new SurveyQuestion
                {
                    Id = -26,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -41,
                    ReplyType = QuestionReplyTypes.Text,
                    Quesiton = "SSL Type",
                    Order = 1
                },
                new SurveyQuestion
                {
                    Id = -27,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -41,
                    ReplyType = QuestionReplyTypes.Text,
                    Quesiton = "SSL Location (Server Name/Location)",
                    Order = 2
                },
                new SurveyQuestion
                {
                    Id = -28,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -42,
                    Quesiton = "Website Name",
                    Order = 0,
                },
                new SurveyQuestion
                {
                    Id = -29,
                    SurveyStepId = -2,
                    ParentSurveyQuestionId = -42,
                    Quesiton = "Website Location (Server Name/Location)",
                    Order = 1
                },
                new SurveyQuestion
                {
                    Id = -30,
                    SurveyStepId = -3,
                    ParentSurveyQuestionId = -43,
                    Quesiton = "Name of Server",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 0
                },
                new SurveyQuestion
                {
                    Id = -31,
                    SurveyStepId = -3,
                    ParentSurveyQuestionId = -43,
                    Quesiton = "Describe the Type of Server",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 1
                },
                new SurveyQuestion
                {
                    Id = -32,
                    SurveyStepId = -3,
                    ParentSurveyQuestionId = -43,
                    Quesiton = "OS Type & Version",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 2
                },
                new SurveyQuestion
                {
                    Id = -33,
                    SurveyStepId = -3,
                    ParentSurveyQuestionId = -43,
                    Quesiton = "Total Storage of Server in (GB'S TB'S) & Partitions",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 3
                },
                new SurveyQuestion
                {
                    Id = -34,
                    SurveyStepId = -3,
                    ParentSurveyQuestionId = -43,
                    Quesiton = "State of Server (Physical, Virtual, Hyper-Visor)",
                    ReplyType = QuestionReplyTypes.Text,
                    Order = 4
                },
            });
            modelBuilder.Entity<ClientSurveys>().HasData(new ClientSurveys
            {
                Id = -1,
                ClientSurveyKey = Guid.Empty,
                ClientId = -1,
                SurveyId = -1,
                IsComplete = false,
                RequestedEndDate = null,
                RequestedStartDate = null
            });
            modelBuilder.Entity<Reply>().HasData(new[]
            {
                new Reply
                {
                    Id = -1,
                    ClientSurveyId = -1,
                    SurveyQuestionId = -1,
                    ReplyData = "Azure",
                    GroupIndex = null
                }
            });
        }
        #endregion
    }
}
