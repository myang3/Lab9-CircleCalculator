using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_CircleCalculator
{
    public class Validator
    {
        public static double validateRadius()
        {
            double radius;
            do
            {
                bool rinput = double.TryParse(Console.ReadLine(), out radius);
                if (radius <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid radius: ");
                }
            } while (radius <= 0);

            return radius;
        }

        public static string continueOrQuit()
        {
            string choice;
            do
            {
                Console.WriteLine("Continue (y/n)");
                choice = Console.ReadLine();
                if((choice != "y") && (choice != "n"))
                {
                    Console.WriteLine("Incorrect Response, Please Try Again.");
                }

            } while ((choice != "y") && (choice != "n"));
            return choice;

        }
    }
}
