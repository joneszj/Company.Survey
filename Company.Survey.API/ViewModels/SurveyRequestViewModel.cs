using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.API.ViewModels
{
    public class SurveyRequestViewModel
    {
        public Guid Key { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
