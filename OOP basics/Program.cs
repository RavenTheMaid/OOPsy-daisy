namespace OOP_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Slim";
            p.LastName = "Shady";
            p.BirthDate = new DateTime(1999, 9, 9);
            p.Height = 185;
            p.Weight = 100;

            string output = p.GetFullName();
            Console.WriteLine(output);
            
            string initials = p.GetInitials();
            Console.WriteLine(initials);
            
            int age = p.GetAgeToday();
            Console.WriteLine(age);

            bool isOlder = p.IsOlderThan(26);
            Console.WriteLine(isOlder);

            DateTime date = new DateTime(2080, 9, 9);
            int ageAtDate = p.GetAgeAt(date);
            Console.WriteLine(ageAtDate);

            double bmi = p.GetBMI();
            Console.WriteLine(bmi);

            p.PersonDescription();
        }
    }
}
