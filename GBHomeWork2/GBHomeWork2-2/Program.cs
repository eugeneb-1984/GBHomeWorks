using System;

namespace GBHomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца от 1 до 12:");
            var CurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (CurrentMonth >= 1 && CurrentMonth <=12)
            {
                string CurrentMonthName = Enum.GetName(typeof(MonthEnum), CurrentMonth);
                Console.WriteLine($"Название текущего месяца: {CurrentMonthName}");
            }
            else
            {
                Console.WriteLine("Вы не ввели порядковый номер месяца");
            }
        }
    }
}
