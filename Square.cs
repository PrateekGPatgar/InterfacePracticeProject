using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeProject
{
    internal class Square : IShape
    {
        double length;
        double area;
        public void AcceptSquareValye()
        {
            Console.WriteLine("Enter the length: ");
            length = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = length * length;
            Console.WriteLine("Area of the Square = " + area);
        }
    }
}
