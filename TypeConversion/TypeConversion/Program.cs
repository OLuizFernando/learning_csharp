using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? "); //      Console.ReadLine() always returns a string,
            int age = int.Parse(Console.ReadLine()); // so it must be converted to be stored in an int variable

            if (age < 16)
            {
                Console.WriteLine("In Brazil, you cannot vote yet.");
            }
            else if (age >= 18 && age <= 70)
            {
                Console.WriteLine("In Brazil, you are required to vote.");
            }
            else // 16, 17 and > 70
            {
                Console.WriteLine("In Brazil, you vote by choice.");
            }

            Console.ReadKey();
        }
    }
}
