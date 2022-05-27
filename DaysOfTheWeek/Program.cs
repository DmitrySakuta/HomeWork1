using System;

namespace DaysOfTheWeek
{
    class Program
    {

        static string getNameDays(int numberDay) 
        {                      
            switch (numberDay)
            {
                case 1: return "Monday"; 
                case 2: return "Tuesday"; 
                case 3: return "Wednesday"; 
                case 4: return "Thursday"; 
                case 5: return "Friday"; 
                case 6: return "Saturday"; 
                case 7: return "Sunday";

                default: return "Day is not defined!";
            }

        }

        static void outputConsole() 
        {
            byte numberDay;

            do
            {
                Console.WriteLine("Please, enter a day number!");
                if (!byte.TryParse(Console.ReadLine(), out numberDay)) {outputConsole(); return;}
           
            }
            while (7<numberDay || numberDay<1);

            Console.WriteLine($"Day of the week: {getNameDays(numberDay)} \n");
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
