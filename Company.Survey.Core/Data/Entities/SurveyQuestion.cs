﻿using Company.Survey.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class SurveyQuestion : CoreBase
    {
        [Required]
        public string Quesiton { get; set; }
        public string Note { get; set; }
        public int Order { get; set; }
        [Required]
        public QuestionReplyTypes ReplyType { get; set; } = QuestionReplyTypes.Text;
        public ICollection<Reply> PossibleReplies { get; set; }
        public int SurveyStepId { get; set; }
        public SurveyStep SurveyStep { get; set; }
        public int? ParentSurveyQuestionId { get; set; }
        public SurveyQuestion ParentSurveyQuestion { get; set; }
        public ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
