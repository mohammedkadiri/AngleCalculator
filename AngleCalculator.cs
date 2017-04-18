using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
/// This is a simple program which calculates the distance between two points and the angle between those points
/// </summary>
    class Program
    {
        /// <summary>
        /// This is a simple program which calculates the distance between two points and the angle between those points
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {   
            //Declare and intialize variables
            float point1X = 0;
            float point1Y = 0;
            float point2X = 0;
            float point2Y = 0;
            float deltaX = 0;
            float deltaY = 0;
            float distance = 0;
            double angle = 0;

            //Print this message to the screen and then get the users points
            Console.WriteLine("Welcome this application will calculate the distance between two points and the angle between those points");
            Console.WriteLine("Enter your point at x1 : ");
            point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your point at y1 : ");
            point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your point at x2 : ");
            point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your point at y2 : ");
            point2Y = float.Parse(Console.ReadLine());

            //Calculate the distance between the points at the X- axis and also the Y-axis
            deltaX = point2X - point1X;
            deltaY = point2Y - point1Y;

            //Calculate the longest side
            distance = (float)(Math.Sqrt(deltaX * deltaX + deltaY * deltaY));

            //Calculate the angle and then convert it to degrees
            angle = Math.Atan2(deltaY, deltaX);
            angle = angle * (180/Math.PI);

            //Print to the screen the distance and the angle
            Console.WriteLine("The points " + "(" + point1X + " , " + point1Y + ")" + " and (" + point2X + " , " + point2Y + ") the distance between the points is :  " + String.Format("{0:f3}", distance) + "cm");
            Console.WriteLine("The angle between  the two points is : " + angle.ToString("N3")+ " degrees");
        }
    }
}
