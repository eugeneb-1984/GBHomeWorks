using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine(Properties.Settings.Default.Greeting);
                Console.WriteLine("Как вас зовут?");
                Properties.Settings.Default.Name = Console.ReadLine();
                Console.WriteLine("Сколько вам лет?");
                Properties.Settings.Default.Age = Console.ReadLine();
                Console.WriteLine("Опишите ваш род деятельности");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                CheckInputAndFinish();
            }
            else
            {
                Console.WriteLine($"Вас зовут {Properties.Settings.Default.Name}");
                Console.WriteLine($"Ваш возраст: {Properties.Settings.Default.Age}");
                Console.WriteLine($"Ваш род деятельности: {Properties.Settings.Default.Occupation}");
            }
            Console.WriteLine("Нажмите любую клавишу для завершения программы");
            Console.ReadKey();
        }
        static void CheckInputAndFinish()
        {
            if (Properties.Settings.Default.Name.Any() && Properties.Settings.Default.Age.Any() && Properties.Settings.Default.Occupation.Any())
            {
                Properties.Settings.Default.Save();
                Console.WriteLine("Спасибо, введенные данные сохранены. Вы увидите их при следующем запуске программы.");

            }

            else
            {
                Console.WriteLine("Пропущен ввод для одного или нескольких вопросов. Вам нужно будет повторно ввести данные при следующем запуске программы.");
                
            }
        }
    }
}
