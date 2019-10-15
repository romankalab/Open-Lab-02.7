using System;

namespace Open_Lab_02._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            bool answer = IsTimeForMilkAndCookies(year, month, day);

            Console.WriteLine($"{answer}");
        }
        private static bool IsTimeForMilkAndCookies(int year, int month, int day)
        {
            return year == 2019 && month == 12 && day == 24;
        }
    }
}
