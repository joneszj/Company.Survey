using System;
using System.Collections.Generic;

namespace Company.Survey.Core.Data.Entities
{
    public class ClientSurveys : CoreBase
    {
        public Guid ClientSurveyKey { get; set; }
        public bool IsComplete { get; set; } = false;

        public DateTime? RequestedStartDate { get; set; }
        public DateTime? RequestedEndDate { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public ICollection<Reply> ClientQuestionReplies { get; set; }
    }
}
