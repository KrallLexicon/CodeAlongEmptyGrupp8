namespace CodeAlongEmpty.Models
{
    public class PersonModel
    {

        public static string WriteMessage()
        {
            return "Please enter your name and age:";
        }

        public string CheckAge(int age)
        {
            if (age >= 18)
                return "You are allowed to vote!";
            else
                return "You are too young to vote!";
        }
    }
}
