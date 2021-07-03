using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255 через пробел");
            string input = Console.ReadLine();

            if (CheckInputValidity(input)) // проверяем корректность каждого введённого числа
            {
                byte[] byteArray = BuildByteArray(input); //строим массив байтов из введённых чисел
                string filename = "bytes.bin";
                File.WriteAllBytes(filename, byteArray);
                Console.WriteLine($"Введённые числа успешно записаны в файл {filename}");
            }
            else
            {
                Console.WriteLine("Одно или несколько чисел введены неправильно: введено не число, или число за пределами диапазона от 0 до 255.");
                Console.WriteLine("Перезапустите программу и попробуйте снова.");
                Console.WriteLine("Нажмите любую клавишу, чтобы закрыть программу");
                Console.ReadKey();
            }
        }

        static bool CheckInputValidity (string input)
        {
            var inputArray = input.Split(' ');
            bool isInputValid = true;
            foreach (string i in inputArray)
            {
                int inputNum;
                bool isCorrectNum = (int.TryParse(i, out inputNum) && inputNum >= 0 && inputNum <= 255);
                if (!isCorrectNum)
                {
                    isInputValid = false;
                    break;
                }
            }
            return isInputValid;
        }

        static byte[] BuildByteArray(string input)
        {
            var inputArray = input.Split(' ');
            byte[] byteArray = new byte[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(inputArray[i]);
            }
        return byteArray;
        }
    }
}