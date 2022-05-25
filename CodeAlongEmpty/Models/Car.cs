using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeAlongEmpty.Models
{
    public class Car
    {
        [Key]
        public string RegNumber { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        
        public string CarModel { get; set; }


        public List<CarOwner> CarOwners { get; set; }


    }
}
