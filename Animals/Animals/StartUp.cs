﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat(" Pesho", "Whiskas");
            Animal dog = new Dog(" Gosho", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
        
    }
}
