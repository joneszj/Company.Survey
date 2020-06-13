
using System.Collections.Generic;

namespace Company.Survey.Core.Data.Entities
{
    public class SurveyQuestionGroup : CoreBase
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string ExampleReplies { get; set; }
        public ICollection<SurveyQuestion> SurveyGroupQuestions { get; set; }
    }
}
