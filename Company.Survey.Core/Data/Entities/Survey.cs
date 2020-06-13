
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class Survey : CoreBase
    {
        public bool IsComplete { get; set; } = false;
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
        public int Version { get; set; }
        [Required]
        public DateTime DateOfQuestionnaire { get; set; }
        public DateTime RequestedStartDate { get; set; }
        public DateTime RequestedEndDate { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// Requested Survey Questions & Possible Replies
        /// </summary>
        public ICollection<SurveyStep> SurveySteps { get; set; }
    }
}
