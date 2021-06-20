using System;

namespace GbHomeWork2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой максимум температуры за сутки?");
            var TempMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какой минимум температуры за сутки?");
            var TempMin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Какой сейчас месяц? Укажите номер от 1 до 12");
            var CurrentMonth = Convert.ToInt32(Console.ReadLine());

            double TempAvg = (TempMax + TempMin) / 2;
            Console.WriteLine($"Средняя температура за сутки: {TempAvg}");

            if (TempAvg > 0 && (CurrentMonth == 1 || CurrentMonth == 2 || CurrentMonth == 12))
            {
                Console.WriteLine("Дождливая Зима");
            }

            Console.ReadKey();
        }
    }
}
