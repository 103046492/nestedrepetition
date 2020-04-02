using System;

namespace nestedrepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of rows and columns you want in the half triangle");
            String inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            for(int row = 0; row <= input; row++)
            {
                for(int column = 0; column <= row; column++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
