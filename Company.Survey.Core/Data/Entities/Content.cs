using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class Content : CoreBase
    {
        public string ContentData { get; set; }
        public int StepContentId { get; set; }
        public StepContent StepContent { get; set; }
    }
}
