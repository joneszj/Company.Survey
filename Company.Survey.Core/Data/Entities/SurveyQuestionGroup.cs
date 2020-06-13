
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class SurveyQuestionGroup : CoreBase
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string Note { get; set; }
        public ICollection<SurveyQuestion> SurveyGroupQuestions { get; set; }
        public int SurveyStepId { get; set; }
        public SurveyStep SurveyStep { get; set; }
    }
}
