using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");

            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * (radius * radius);

            Console.WriteLine("Area of circle: " + area);


        }
    }
} 
