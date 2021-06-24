using System;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] EmailDir = new string[5, 2];

            EmailDir[0, 0] = "Eugene";
            EmailDir[0, 1] = "Eugene@gmail.com";
            EmailDir[1, 0] = "Sam";
            EmailDir[1, 1] = "Sam@gmail.com";
            EmailDir[2, 0] = "Mike";
            EmailDir[2, 1] = "Mike@gmail.com";
            EmailDir[3, 0] = "Rob";
            EmailDir[3, 1] = "Rob@gmail.com";
            EmailDir[4, 0] = "Ed";
            EmailDir[4, 1] = "Ed@gmail.com";

            for (int x = 0; x < 5; x++)
            {
                int y = 0;
                Console.Write($"{EmailDir[x, y]}'s email is ");
                y++;
                Console.WriteLine(EmailDir[x, y]);
            
            }
        }
    }
}
