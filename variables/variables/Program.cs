using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            string name = "Luiz Fernando";
            float height = 1.73f; // float numbers must have "f" at the end
            bool isEmployed = false;

            Console.WriteLine("Hi! My name's {0}, I'm {1} years old and I'm {2}m tall.", name, age, height); // placeholders must have an index

            Console.Write("At the moment, ");

            if (isEmployed)
            {
                Console.WriteLine("I'm employed. :)");
            }
            else
            {
                Console.WriteLine("I'm not employed. :(");
            }

            Console.ReadKey();
        }
    }
}
