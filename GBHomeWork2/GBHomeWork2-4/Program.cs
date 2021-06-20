using System;

namespace GBHomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Чек можно посмотреть вот здесь: https://ofd-ya.ru/k?UY2klvTC7yBzyAKZcGCs
             * Я скопировал первые 4 строки чека.
             * Получилось ужасно, т.к. по-правильному надо делать с циклами и чем-то вроде Console.SetCursorPosition.
             * Но циклы - это материал следующего урока, и заранее его штудировать не было времени.
             * Поэтому сорян - какой бриф, такой и креатив :)
             */

            var Product = "Лицензия на ПО Альбато, тариф \"Базовый\"";
            int Quantity = 1;
            decimal Price = 990.00M;
            decimal Amount = Quantity * Price;

            string Line1 = $"# 1. {Product} #";

            string Line2Left = $"# {Quantity.ToString()} x {Price.ToString()}";
            string Line2Right = $"{Amount.ToString()} #";
            string Line2Mid = new string(' ', Line1.Length - Line2Left.Length - Line2Right.Length);

            string Line3Left = "# Услуга";
            string Line3Right = "Полный расчёт #";
            string Line3Mid = new string(' ', Line1.Length - Line3Left.Length - Line3Right.Length);

            string Line4 = $"# {new string(' ', Line1.Length - 4)} #";

            string LineTopBottom = $"{new string('#', Line1.Length)}";

            Console.WriteLine(LineTopBottom);
            Console.WriteLine(Line1);
            Console.WriteLine(Line2Left + Line2Mid + Line2Right);
            Console.WriteLine(Line3Left + Line3Mid + Line3Right);
            Console.WriteLine(Line4);
            Console.WriteLine(LineTopBottom);
            Console.ReadKey();     
        }
    }
}
