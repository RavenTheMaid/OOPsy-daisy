using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basics
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName{ get; set;}
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public string GetInitials()
        {
            string firstInitial = FirstName![0].ToString();
            string lastInitial = LastName![0].ToString();
            string initials = firstInitial + lastInitial;
            return initials;
        }
        public int GetAgeToday()
        {
            TimeSpan ageToday = DateTime.Today - BirthDate;
            double yearsOld = Math.Truncate(ageToday.TotalDays) / 365;
            int age = (int)yearsOld;
            return age;
        }
        public bool IsOlderThan(int age)
        {
            TimeSpan ageToday = DateTime.Today - BirthDate;
            double years = Math.Truncate(ageToday.TotalDays) / 365;
            int yearsOld = (int)years;
            if (yearsOld > age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetAgeAt(DateTime date)
        {
            TimeSpan ageAtDate =  date - BirthDate;
            double years = Math.Truncate(ageAtDate.TotalDays) / 365;
            int age = (int)years;
            return age;
        }
        public double GetBMI()
        {
            double height = Height / 100;
            double bmi = Weight / (height * height);
            return bmi;
        }
        public string BMIDescription()
        {
            string bmiDescription = default!;

            double height = Height / 100;
            double bmi = Weight / (height * height);
            
            if (bmi <= 18.5)
            {
                bmiDescription = "Underweight among adults";
            }
            else if (bmi >= 25)
            {
                bmiDescription = "Overweight among adults";
                
            }
            else if (bmi >= 30)
            {
                bmiDescription = "Obesity among adults";
                
            }
            else
            {
                bmiDescription = "Healthy among adults";
            }
            return bmiDescription;
        }
        public void PersonDescription()
        {
            string bmiDescription = BMIDescription();
            Console.WriteLine($"" +
                $"{FirstName} {LastName} was born the {BirthDate.Day}. {BirthDate.ToString("MMMM")}.\n" +
                $"today {DateTime.Today.ToString("yyyy MMMM dd")} he is {GetAgeAt(DateTime.Today)} years old " +
                $"and has a BMI of {GetBMI()} which means he is {bmiDescription.ToLower()}");
        }
    }

}
