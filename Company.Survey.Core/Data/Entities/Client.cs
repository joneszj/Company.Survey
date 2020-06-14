
using System.Collections.Generic;

namespace Company.Survey.Core.Data.Entities
{
    public class Client : CoreBase
    {
        public ICollection<ClientSurveys> ClientSurveys { get; set; }
    }
}
