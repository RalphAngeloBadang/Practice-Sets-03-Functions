using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static double HeronsFormula(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;

            double Area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return Area;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Triangle side A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Triangle side B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Triangle side C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            double result = HeronsFormula(A, B, C);

            Console.WriteLine("The Area of the Triangle using the Heron's Formula is: " + result);

            Console.ReadKey();

        }
    }
}
