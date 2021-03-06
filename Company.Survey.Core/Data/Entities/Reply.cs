﻿
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class Reply : CoreBase
    {
        public string ReplyData { get; set; }
        public int SurveyQuestionId { get; set; }
        public int? GroupIndex { get; set; } = null;
        public SurveyQuestion SurveyQuestion { get; set; }
        public int? ClientSurveyId { get; set; }
        public ClientSurveys ClientSurvey { get; set; }
    }
}
