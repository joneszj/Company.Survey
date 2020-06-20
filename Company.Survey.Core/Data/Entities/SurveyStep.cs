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
        public int SurveyId { get; set; }
        public int SurveyVersion { get; set; }
        public Survey Survey { get; set; }
    }
}
