﻿using Company.Survey.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Survey.API.ViewModels
{
    public class SurveyViewModel
    {
        public SurveyViewModel(ClientSurveys clientSurvey)
        {
            IsComplete = clientSurvey.IsComplete;
            Title = clientSurvey.Survey.Title;
            CompanyName = clientSurvey.Survey.CompanyName;
            CompanySite = clientSurvey.Survey.CompanySite;
            Contact = $"{clientSurvey.Survey.ContactTitle} {clientSurvey.Survey.ContactPhone}";
            DateOfQuestionnaire = clientSurvey.Survey.DateOfQuestionnaire;
            Steps = clientSurvey.Survey.SurveySteps.Select(surveyStep => new Step(surveyStep));

            SetClientQuestionReplies(clientSurvey.ClientQuestionReplies);
        }

        public bool IsComplete { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string CompanySite { get; set; }
        public string Contact { get; set; }
        public DateTime DateOfQuestionnaire { get; set; }
        public DateTime RequestedStartDate { get; set; }
        public DateTime RequestedEndDate { get; set; }
        public IEnumerable<Step> Steps { get; set; }

        // TODO: Candidate for optimization
        private void SetClientQuestionReplies(ICollection<Reply> reply)
        {
            this.Steps.ToList().ForEach(step => 
            { 
                step.Questions.Where(e => reply.Select(r => r.SurveyQuestionId).Contains(e.Id)).ToList()
                .ForEach(e => 
                {
                    e.ClientReply = reply.Where(r => r.SurveyQuestionId == e.Id).FirstOrDefault().ReplyData;
                }); 
            });
        }
    }

    public class Step
    {
        public Step(SurveyStep step)
        {
            Title = step.Title;
            Order = step.Order;
            StepContent = new Content(step.StepContent);
            Questions = step.Questions.Select(question => new Question(question));
            GroupedQuestions = step.QuestionGroups.Select(group => new Group(group));
        }

        public string Title { get; set; }
        public int Order { get; set; }
        public Content StepContent { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Group> GroupedQuestions { get; set; }
    }

    public class Content
    {
        public Content(StepContent stepContent)
        {
            Title = stepContent.Title;
            ContentBlocks = stepContent.ContentBlocks.Select(e => e.ContentData);
        }
        public string Title { get; set; }
        public IEnumerable<string> ContentBlocks { get; set; }
    }

    public class Question
    {
        public Question(SurveyQuestion question)
        {
            Id = question.Id;
            QuesitonText = question.Quesiton;
            Note = question.Note;
            Order = question.Order;
            ExampleReplies = question.PossibleReplies.Select(e => e.ReplyData);
            GroupId = question?.SurveyQuestionGroup?.Id ?? 0;
        }
        public int Id { get; set; }
        public string QuesitonText { get; set; }
        public string Note { get; set; }
        public int Order { get; set; }
        public IEnumerable<string> ExampleReplies { get; set; }
        public int GroupId { get; set; }
        public string ClientReply { get; set; }
    }

    public class Group
    {
        public Group(SurveyQuestionGroup group)
        {
            Title = group.Title;
            Note = group.Note;
            Order = group.Order;
        }

        public string Title { get; set; }
        public string Note { get; set; }
        public int Order { get; set; }
    }
}
