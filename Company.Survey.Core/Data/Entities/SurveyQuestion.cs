using Company.Survey.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class SurveyQuestion : CoreBase
    {
        [Required]
        public string Quesiton { get; set; } = string.Empty;
        public string Note { get; set; }
        public int Order { get; set; }
        [Required]
        public QuestionReplyTypes ReplyType { get; set; }
        public ICollection<Reply> PossibleReplies { get; set; }
        public int SurveyStepId { get; set; }
        public SurveyStep SurveyStep { get; set; }
        public int? SurveyQuestionGroupID { get; set; }
        public SurveyQuestionGroup SurveyQuestionGroup { get; set; }
    }
}
