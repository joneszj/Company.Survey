using Company.Survey.Core.Comnstants;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public class Client : CoreBase
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [RegularExpression(Regex.OnlyLetterDigitSingleSpace)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(Regex.OnlyLetterDigitSingleSpace)]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public ICollection<ClientSurveys> ClientSurveys { get; set; }
    }
}
