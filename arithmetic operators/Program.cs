﻿using System.Transactions;

namespace arithmetic_operators
{
    internal class Program
    {
        static void main()
        {
            double circumfe = circumf(10);
            Console.WriteLine(circumfe);
            double areab = area(10);
            Console.WriteLine(areab);
            bool modulusb = modulus(16, 4);
            Console.WriteLine(modulusb);
        }
        static double circumf(double radius)
        {
            double circumf = 2 * radius * Math.PI;
            return circumf;
        }
        static double area(double radius)
        {
            double area = radius * radius * Math.PI;
            area = Math.Round(area, 2);
            return area;
        }
        static bool modulus(double a, double b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}