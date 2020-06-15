using System;

namespace Company.Survey.API.ViewModels
{
    public class PutSurveyViewModel
    {
        public DateTime RequestedStartDate { get; set; }
        public DateTime RequestedEndDate { get; set; }
    }
}
