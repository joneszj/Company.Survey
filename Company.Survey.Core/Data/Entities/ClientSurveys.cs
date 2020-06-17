using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Survey.Core.Data.Entities
{
    public class ClientSurveys : CoreBase
    {
        public Guid ClientSurveyKey { get; set; }
        public bool IsComplete { get; set; } = false;

        public DateTime? RequestedStartDate { get; set; } = null;
        public DateTime? RequestedEndDate { get; set; } = null;

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public ICollection<Reply> ClientQuestionReplies { get; set; }
    }
}
