using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Survey.Core.Data.Entities
{
    public abstract class CoreBase
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = "Anonymous";
        public string ModifiedBy { get; set; } = "Anonymous";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
