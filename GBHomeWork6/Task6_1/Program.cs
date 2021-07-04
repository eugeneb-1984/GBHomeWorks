using System;
using System.Diagnostics;
using System.IO;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа показывает текущие процессы и позволяет завершить процесс по ID или по имени");
            string userChoice = "";

            while (userChoice != "4")
            {
                userChoice = ShowMenuAndReturnUserChoice();
                Console.WriteLine($"Ваш ввод: {userChoice}");
                switch (userChoice)
                {
                    case "1":
                        DisplayProcesses();
                        break;

                    case "2":
                        KillProcessById();
                        break;

                    case "3":
                        KillProcessByName();
                        break;

                    case "4":
                        Console.WriteLine("Cпасибо, работа программы завершена.");
                        break;

                    default:
                        Console.WriteLine("Неправильный ввод. Введите число от 1 до 4.");
                        break;
                }
            }
        }

        static string ShowMenuAndReturnUserChoice()
        {
            Console.WriteLine("");
            Console.WriteLine("1 - вывести список запущенных процессов");
            Console.WriteLine("2 - завершить процесс по Id");
            Console.WriteLine("3 - завершить процесс по имени");
            Console.WriteLine("4 - завершить работу программы");
            Console.WriteLine("");
            Console.WriteLine("Введите цифру от 1 до 4 чтобы сделать выбор");
            var userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        static void DisplayProcesses()
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process item in processList)
            {
                Console.WriteLine($"{item.Id} {item.ProcessName}");
            }
            return;
        }

        static void KillProcessByName()
        {
            Console.WriteLine("Введите имя процесса. Будут завершены все процессы, подпадающие под введённое имя:");
            string userInput = Console.ReadLine();
            Process[] processesToKillByName = Process.GetProcessesByName(userInput);

            if (processesToKillByName.Length > 0)
            {
                foreach (Process item in processesToKillByName)
                {
                    item.Kill();
                    Console.WriteLine($"Процесс {item.ProcessName} (Id {item.Id}) успешно завершён");
                }
            }

            else
            {
                Console.WriteLine($"Процессов с именем {userInput} не найдено.");
            }
            return;
        }

        static void KillProcessById()
        {
            Console.WriteLine("Введите идентификатор процесса:");
            string userInput = Console.ReadLine();
            int processId;

            if(!(int.TryParse(userInput, out processId)))
            {
                Console.WriteLine("Вы ввели неправильный идентификатор. Введите цифру.");
            }

            else
            {
                try
                {
                    Process processToKillById = Process.GetProcessById(processId);
                    processToKillById.Kill();
                    Console.WriteLine($"Процесс {processToKillById.ProcessName} (Id {processToKillById.Id}) успешно завершён");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Не обнаружено запущенного процесса с идентификатором {processId}");
                    Console.WriteLine($"Подробности ошибки: {ex.Message}");
                }
            }
            return;
            
        }
    }
}
