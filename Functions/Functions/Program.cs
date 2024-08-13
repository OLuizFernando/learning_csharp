using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Price: $");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Percentage off (as float): ");
            float percentageOff = float.Parse(Console.ReadLine());

            Console.WriteLine("New price with discount: ${0}", CalcPrice(price, percentageOff));

            Console.ReadKey();
        }

        static float CalcPrice(float price, float percentageOff) // return and parameters type must be specified
        {
            float discount = price * percentageOff;
            float newPrice = price - discount;

            return newPrice;
        }
    }
}
