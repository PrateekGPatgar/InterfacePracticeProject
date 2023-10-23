using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeProject
{
    internal class Circle : IShape
    {
        double area;
        double PI = 3.14;
        double r;

        public void InputValues()
        {
            Console.WriteLine("Enter the radius: ");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = 2 * PI * r;

            Console.WriteLine("Area of the Circle = " + area);
        }
    }
}
