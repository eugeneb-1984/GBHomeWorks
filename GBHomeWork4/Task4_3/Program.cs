using System;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            var input = Console.ReadLine();
            string result = (int.TryParse(input, out int monthNum)) ? $"Сейчас {GetSeasonByMonth(monthNum)}": "Ошибка: Вы ввели не число";
            Console.WriteLine(result);
        }

        static string GetSeasonByMonth(int monthValue)
        {
            switch(monthValue)
            {
                case 12:
                case 1:
                case 2:
                    return ((Seasons)1).ToString();

                case 3:
                case 4:
                case 5:
                    return ((Seasons)2).ToString();

                case 6:
                case 7:
                case 8:
                    return ((Seasons)3).ToString();

                case 9:
                case 10:
                case 11:
                    return ((Seasons)4).ToString();

                default:
                    return "Ошибка: введите число от 1 до 12";
            }

        }
    }
}
