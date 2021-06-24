using System;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string diagSource = "diagonal";
            char [,] myArray = new char [diagSource.Length, diagSource.Length];

            for (int x = 0; x < diagSource.Length; x++)
            {
                for (int y = 0; y < diagSource.Length; y++)
                {
                    if (x == y)
                    {
                        myArray[x, y] = diagSource[x];
                    }
                    else
                    {
                        myArray[x, y] = ' ';
                    }
                   
                }
                                    
            }

            for (int x = 0; x< diagSource.Length; x++)
            {
                for (int y = 0; y < diagSource.Length; y++)
                {
                    Console.Write($"{myArray[x, y]} ");
                }
                Console.WriteLine();                
            }
            

        }
    }
}
