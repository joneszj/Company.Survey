using Company.Survey.Core.Enums;

namespace Company.Survey.Admin.Models.Question
{
    public class PutQuestion
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Note { get; set; }
        public int StepId { get; set; }
        public int? ParentId { get; set; }
        public int? Order { get; set; }
        //public int ReplyType { get; set; }
        //public int StepId { get; set; }
        //public int? ParentId { get; set; }
    }
}
