using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleArea
{
    class Triangle
    {
        double baseA;
        double height;
        public void AcceptDetails()
        {
            //length = 2; width = 3;
            Console.WriteLine("please Enter the base of the triangle:");
            baseA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the heigt of the triangle:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        public double getArea()
        {
            return (0.5*(baseA * height));
        }
        public void Display()
        {
            Console.WriteLine("The base of triangle:{0}", baseA);
            Console.WriteLine("The heiht of triangle:{0}", height);
            Console.WriteLine("The Area of Rectangle:{0}", getArea());

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle r = new Triangle();
            r.AcceptDetails();
            r.Display();
            //r.Display();
            Console.ReadKey();
        }
    }
}
