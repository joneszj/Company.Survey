
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class Reply : CoreBase
    {
        public string ReplyData { get; set; }
        public int SurveyQuestionId { get; set; }
        public SurveyQuestion SurveyQuestion { get; set; }
    }
}
