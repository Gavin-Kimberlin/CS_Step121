using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\r\nPlease enter the package weight: ");
            byte weight = Convert.ToByte(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                System.Threading.Thread.Sleep(2500);
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            byte width = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            byte height = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            byte length = Convert.ToByte(Console.ReadLine());

            int total = (weight * width * height * length) / 100;
            
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                System.Threading.Thread.Sleep(2500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00\r\nThank you.\r\nPress ENTER to close the program.");
            }
            Console.ReadLine();
        }
    }
}
