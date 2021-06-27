using System;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ivanFirstName = "Иван";
            string ivanPatronymic = "Иванович";
            string ivanLastName = "Иванов";


            string petrFirstName = "Пётр";
            string petrPatronymic = "Петрович";
            string petrLastName = "Петров";

            string andreyFirstName = "Андрей";
            string andreyPatronymic = "Андреевич";
            string andreyLastName = "Андреев";


            Console.WriteLine("Вывод ФИО полностью:");
            GetFullName(ivanFirstName, ivanLastName, ivanPatronymic);
            GetFullName(petrFirstName, petrLastName, petrPatronymic);
            GetFullName(andreyFirstName, andreyLastName, andreyPatronymic);
         

            static void GetFullName(string firstName, string lastName, string patronymic)

            {
                Console.WriteLine($"{firstName} {patronymic} {lastName}");
            }
        }
    }
}
