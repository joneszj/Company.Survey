using Company.Survey.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Survey.API.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel() { }
        public ClientViewModel(Client client)
        {
            FirstName = client.FirstName;
            LastName = client.LastName;
            CompanyName = client.CompanyName;
            Phone = client.Phone;
            Email = client.Email;
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Phone]
        public string Phone { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
