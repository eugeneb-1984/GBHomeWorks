using System;

namespace GBHomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой максимум температуры за сутки?");
            var TempMax = (Convert.ToDouble(Console.ReadLine()));
                     
            Console.WriteLine("Какой минимум температуры за сутки?");
            var TempMin = Convert.ToDouble(Console.ReadLine());

            double TempAvg = (TempMax + TempMin) / 2;
            Console.WriteLine($"Средняя температура за сутки: {TempAvg}");
            
            Console.ReadKey();
            
        }
    }
}
