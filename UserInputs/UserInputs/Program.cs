﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);

            Console.ReadKey();
        }
    }
}
