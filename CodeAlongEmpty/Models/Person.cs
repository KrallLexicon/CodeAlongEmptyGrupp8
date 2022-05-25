using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeAlongEmpty.Models
{
    public class Person
    {
        [Key]
        public string SSN { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CarOwner> CarOwners { get; set; }
    }
}
