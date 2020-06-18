using Company.Survey.Core.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Survey.API.ViewModels
{
    public class SurveyViewModel
    {
        public SurveyViewModel(ClientSurveys clientSurvey)
        {
            IsComplete = clientSurvey.IsComplete;
            Title = clientSurvey.Survey.Title;
            Client = new ClientViewModel(clientSurvey.Client);
            CompanyName = clientSurvey.Survey.CompanyName;
            CompanySite = clientSurvey.Survey.CompanySite;
            Contact = $"{clientSurvey.Survey.ContactTitle} {clientSurvey.Survey.ContactPhone}";
            DateOfQuestionnaire = clientSurvey.Survey.DateOfQuestionnaire.ToString("yyyy-MM-dd");
            RequestedStartDate = clientSurvey.RequestedStartDate?.ToString("yyyy-MM-dd");
            RequestedEndDate = clientSurvey.RequestedEndDate?.ToString("yyyy-MM-dd");
            Steps = clientSurvey.Survey.SurveySteps.Select(surveyStep => new Step(surveyStep, clientSurvey.ClientQuestionReplies)).OrderBy(e=>e.Order);
        }

        public bool IsComplete { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string CompanySite { get; set; }
        public string Contact { get; set; }
        public ClientViewModel Client { get; set; }
        public string DateOfQuestionnaire { get; set; }
        public string RequestedStartDate { get; set; }
        public string RequestedEndDate { get; set; }
        public IEnumerable<Step> Steps { get; set; }
    }

    public class Step
    {
        public Step(SurveyStep step, ICollection<Reply> replies)
        {
            Id = step.Id;
            Title = step.Title;
            Order = step.Order;
            StepContent = new Content(step.StepContent);
            Questions = step.Questions.Where(e=>e.ParentSurveyQuestionId == null)
                .Select(question => new Question(question, replies))
                .OrderBy(e => e.Order);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public Content StepContent { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }

    public class Content
    {
        public Content(StepContent stepContent)
        {
            if (stepContent != null)
            {
                Title = stepContent.Title;
                ContentBlocks = stepContent.ContentBlocks.Select(e => HttpUtility.UrlDecode(e.ContentData));
            }
        }
        public string Title { get; set; }
        public IEnumerable<string> ContentBlocks { get; set; }
    }

    public class Question
    {
        public Question(SurveyQuestion question, ICollection<Reply> replies)
        {
            Id = question.Id;
            QuesitonText = question.Quesiton;
            Note = question.Note;
            Order = question.Order;
            ExampleReplies = question?.PossibleReplies?.Select(e => e.ReplyData);
            GroupId = question.ParentSurveyQuestionId;
            GroupedQuestions = question.SurveyQuestions?.Select(e => new Question(e, replies)).OrderBy(e=>e.Order);
            ClientReply = replies.FirstOrDefault(e => e.SurveyQuestionId == question.Id)?.ReplyData;
            GroupedReplies = replies.OrderBy(e=>e.GroupIndex).Where(e=>e.SurveyQuestionId == question.Id)?.Select(e => new GroupedReply { Id = e.Id, Reply = e.ReplyData });
        }

        public int Id { get; set; }
        public string QuesitonText { get; set; }
        public string Note { get; set; }
        public int Order { get; set; }
        public IEnumerable<string> ExampleReplies { get; set; }
        public int? GroupId { get; set; }
        public string ClientReply { get; set; }
        public IEnumerable<GroupedReply> GroupedReplies { get; set; }
        public IEnumerable<Question> GroupedQuestions { get; set; }
    }

    public class GroupedReply
    {
        public int Id { get; set; }
        public string Reply { get; set; }
    }
}
