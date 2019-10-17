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

            bool answer = IsTimeForMilkAndCookies(month, day);

            Console.WriteLine($"{answer}");
        }
        private static bool IsTimeForMilkAndCookies(int month, int day)
        {
            return month == 12 && day == 24;
        }
    }
}
