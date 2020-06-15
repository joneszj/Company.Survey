namespace Company.Survey.API.ViewModels
{
    public class PutPostReplyViewModel
    {
        public int SurveyQuestionId { get; set; }
        public string Value { get; set; }
        public int? GroupdIndex { get; set; }
    }
}
