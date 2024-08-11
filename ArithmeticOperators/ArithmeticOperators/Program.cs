using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exampleAddition = 5 + 2;
            int exampleSubtraction = 5 - 2;
            int exampleMultiplication = 5 * 2;

            // differences in divisions
            int exampleIntDivision = 5 / 2; // int 5 / 2 = 2
            float exampleFloatDivision = 5 / 2; // float 5 / 2 = 2
            exampleFloatDivision = 5f / 2; // float 5f / 2 = 2.5
            //                      ^ to get a float result, at least one number in the operation must be a float
            //                      ^ 5f == 5.0f
        }
    }
}
