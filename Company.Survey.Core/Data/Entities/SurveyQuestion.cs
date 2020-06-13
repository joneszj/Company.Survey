using Company.Survey.Core.Enums;
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
        public string[] PossibleReplies { get; set; }
        /// <summary>
        /// TODO: this may be best to separate from the SurveyQuestion Class
        /// </summary>
        public string[] SubmittedReplies { get; set; }
    }
}
