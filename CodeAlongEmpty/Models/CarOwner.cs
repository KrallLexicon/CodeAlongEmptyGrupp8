namespace CodeAlongEmpty.Models
{
    public class CarOwner
    {
        public string RegNumber { get; set; }

        public Car Car { get; set; }
        public string SSN { get; set; }

        public Person Owner { get; set; }
    }
}
