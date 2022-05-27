using System;

namespace MultiplicationTable
{
    class Program
    {
        static long MultiplicationMethod(long number)
        {
            for(int i=0; i<10; i++) 
            {
                Console.WriteLine($"{number}x{i}={number*i}");
            }
          
            return 5;
        }
        
        static void outputConsole()
        {
            long number;
            Console.WriteLine("Please, enter a number!");
            if (!long.TryParse(Console.ReadLine(), out number)) { outputConsole(); return; }
            MultiplicationMethod(number);
            string anser;
            do
            {
                Console.WriteLine("Do you wanna repeat? Enter Y/N.");
                anser = Console.ReadLine();

                anser = anser.ToUpper();
            }
            while (anser != "Y" && anser != "N");
            if (anser == "Y") outputConsole();
            else Console.WriteLine("The job is done!");

        }

        static void Main(string[] args)
        {
          
            outputConsole();
        }
    }
}
