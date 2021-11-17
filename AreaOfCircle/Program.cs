using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");

            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            double circumference = 2 * Math.PI * radius;

            double diameter = 2 * radius;

            Console.WriteLine("Area of circle: " + area);

            Console.WriteLine("Circumference of circle: " + circumference);

            Console.WriteLine("Diameter of circle: " + diameter);

            Console.WriteLine("\nWhat is the average mpg of your car?");

            double avgMpg = Convert.ToDouble(Console.ReadLine());

            double roadTripGas = circumference / avgMpg;

            Console.WriteLine("You would burn " + roadTripGas + " gallons of gas, traveling around this circle.");
        }
    }
} 
