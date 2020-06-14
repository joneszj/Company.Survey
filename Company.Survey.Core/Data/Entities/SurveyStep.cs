using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int SurveyId { get; set; }
        public int SurveyVersion { get; set; }
        public Survey Survey { get; set; }
    }
}
