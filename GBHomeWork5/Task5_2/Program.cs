using System;
using System.IO;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string CurrentTime = $"{DateTime.Now:t}\n";
            File.AppendAllText("startup.txt", CurrentTime);
        }
    }
}
