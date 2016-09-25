using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_CircleCalculator
{
    class CircleApp
    {
        static string keepGoing;

        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Welcome to the Circle Tester");

            do
            {
                Console.WriteLine("Enter radius: ");
                radius = Validator.validateRadius();
                Circle C = new Circle(radius);
                Console.WriteLine("Circumference: " + C.getFormattedCircumference());
                Console.WriteLine("Area: " + C.getFormattedArea());

                Console.WriteLine("Continue? (y/n): ");
                keepGoing = Console.ReadLine();
            } while (keepGoing.ToLower() == "y" || keepGoing.ToLower() == "yes");

             Console.WriteLine("Goodbye. You Created " + Circle.getObjectCount() + " Circle object (s).");
             Console.ReadLine();
        }
    }
}
