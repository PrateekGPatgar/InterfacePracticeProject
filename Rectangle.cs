using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeProject
{
    internal class Rectangle : IShape
    {
        double length;
        double breadth;
        double area;

        public void AcceptReactangleValue()
        {
            Console.WriteLine("Enter the length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Breadth: ");
            breadth = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = length * length;
            Console.WriteLine("Area of rectangle = " + area);
        }
    }
}
