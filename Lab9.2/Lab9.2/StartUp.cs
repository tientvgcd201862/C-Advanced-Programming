﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    internal class StartUp
    {
        public static void Main()
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
