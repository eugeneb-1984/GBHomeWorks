using System;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел через пробел:");
            string stringOfNumbers = Console.ReadLine();
            Console.WriteLine($"Посчитанная сумма: {GetSumByNumbers(stringOfNumbers)}");
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть программу");
            Console.ReadKey();
        }

        static int GetSumByNumbers(string stringOfNumbers)
        {
            int sum = 0;
            foreach (var number in stringOfNumbers.Split(' '))
            {
                int num;
                if (int.TryParse(number, out num))
                {
                    sum +=num; 
                }

                else
                {
                    Console.WriteLine("Некорректный ввод. Убедитесь, что все введённые значения являются числами и введены именно через пробел.");
                    sum = 0;
                    break;
                }
            }
            return sum;
        }
    }
}
