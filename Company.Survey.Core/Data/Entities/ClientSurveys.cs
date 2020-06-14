using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Survey.Core.Data.Entities
{
    public class ClientSurveys : CoreBase
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}
