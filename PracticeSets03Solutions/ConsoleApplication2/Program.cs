using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static bool leapYear(double ly)
        {
            if (ly % 4 == 0 && (ly % 100 != 0 || ly % 400 == 0)){
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            double userinput = Convert.ToDouble(Console.ReadLine());

            bool result = leapYear(userinput);
            
            if (result == true) {
            Console.WriteLine("The year " + userinput + " is a leap year");
                }
            else
            {
                Console.WriteLine("The year " + userinput + " is not a leap year");
            }

            Console.ReadKey();

        }
    }
}
