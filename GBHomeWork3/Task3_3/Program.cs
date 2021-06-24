using System;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            for (int i = word.Length - 1; i>=0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
