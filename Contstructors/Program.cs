using static System.Console;
namespace Contstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



        }

        static TimeSpan SalaryPeriod()
        {
            while(true)
            {
                WriteLine("Do you get paid biweekly or monthly?");
                string period = ReadLine()!;

                switch (period.ToLower())
                {
                    case "biweekly":
                        Biweekly();
                        break;
                    case "monthly":
                        Monthly();
                        break;
                    default:
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The input must be biweekly or monthly");
                        ForegroundColor = ConsoleColor.White;
                        ReadKey();
                        break;
                }
            }



            throw new Exception();
        }

        public static TimeSpan  Biweekly()
        {
            
            DateTime periodStart = default;
            bool dateDone = false;
            while (!dateDone)
            {
                Clear();
                WriteLine("What is the date this salary period started? (yyyy-mm-dd");

                dateDone = DateTime.TryParse(ReadLine(), out periodStart);


                if (!dateDone)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The input is invalid");
                    ForegroundColor = ConsoleColor.White;
                    ReadKey();
                }
                DayOfWeek theDay = periodStart.DayOfWeek;
                if (theDay != DayOfWeek.Monday)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The day has to start on a monday");
                    ForegroundColor = ConsoleColor.White;
                    ReadKey();
                }

            }

            DateTime periodEnd = periodStart.AddDays(14);
            TimeSpan salaryPeriod = periodStart - periodEnd;
            return salaryPeriod;
        }

        public static TimeSpan Monthly()
        {
            DateTime periodStart = default;
            bool dateDone = false;
            while (!dateDone)
            {
                Clear();
                WriteLine("What is the date this salary period started? (yyyy-mm-dd");

                dateDone = DateTime.TryParse(ReadLine(), out periodStart);
                if (!dateDone)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The input is invalid");
                    ForegroundColor = ConsoleColor.White;
                    ReadKey();
                }
                DayOfWeek theDay = periodStart.DayOfWeek;
                if (theDay != DayOfWeek.Monday)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The day has to start on a monday");
                    ForegroundColor = ConsoleColor.White;
                    ReadKey();
                }

            }

            DateTime periodEnd = periodStart.AddMonths(1);
            TimeSpan salaryPeriod = periodStart - periodEnd;
            return salaryPeriod;
        }

        public static void TaxProcent();
    }
}
