using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Survey.Core.Data.Entities
{
    public class Survey : CoreBase
    {
        public int Version { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanySite { get; set; }
        [Required]
        public string ContactTitle { get; set; }
        [Required]
        [Phone]
        public string ContactPhone { get; set; }
        [Required]
        public DateTime DateOfQuestionnaire { get; set; }
        public string Title { get; set; }
        public ICollection<SurveyStep> SurveySteps { get; set; }
        [ForeignKey("SurveyId")]
        public ICollection<ClientSurveys> ClientSurveys { get; set; }
    }
}
