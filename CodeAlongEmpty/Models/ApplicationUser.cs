using Microsoft.AspNetCore.Identity;

namespace CodeAlongEmpty.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
