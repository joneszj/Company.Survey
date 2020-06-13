using System.Collections.Generic;

namespace Company.Survey.Core.Data.Entities
{
    public class SurveyStep : CoreBase
    {
        public StepContent StepContent { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        /// <summary>
        /// Collection of individual questions
        /// </summary>
        public ICollection<SurveyQuestion> Questions { get; set; }
        /// <summary>
        /// Collection of grouped questions
        /// </summary>
        public ICollection<SurveyQuestionGroup> QuestionGroups { get; set; }
    }
}
