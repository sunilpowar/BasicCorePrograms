﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to asic program");
            BasicCorePrograms prob = new BasicCorePrograms();
            prob.Check_leap_year();
            prob.largest_num();

            Console.ReadLine();
        }
    }
}


