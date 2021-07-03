using System;
using System.IO;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любой текст:");
            var input = Console.ReadLine();
            string filename = "input.txt";
            File.AppendAllText(filename, input);
            Console.WriteLine($"Спасибо, текст записан в файл {filename}");
            Console.ReadKey();
        }
    }
}
