
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class StepContent : CoreBase
    {
        public string Title { get; set; }
        public ICollection<Content> ContentBlocks { get; set; }
        public int SurveyStepId { get; set; }
        public SurveyStep SurveyStep { get; set; }
    }
}
