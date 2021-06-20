using System;

namespace GbHomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var Number = Convert.ToInt32(Console.ReadLine());

            if (Number%2 == 0)
            {
                Console.WriteLine($"{Number} - это чётное число");
            }
            else
            {
                Console.WriteLine($"{Number} - это нечётное число");
            }
        }
    }
}
