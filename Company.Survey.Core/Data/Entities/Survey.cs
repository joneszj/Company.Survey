
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Survey.Core.Data.Entities
{
    public class Survey : CoreBase
    {
        /// <summary>
        /// Composite Key
        /// </summary>
        [Key, Column(Order = 1)]
        public int Version { get; set; }
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
