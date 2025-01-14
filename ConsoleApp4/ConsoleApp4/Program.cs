﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Fraction f = new Fraction();
            Console.WriteLine("Enter the numerator of the first fraction: ");
            f.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator of the first fraction: ");
            f.Denominator = int.Parse(Console.ReadLine());
            
            Fraction s = new Fraction();
            Console.WriteLine("Enter the numerator of the second fraction: ");
            s.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator of the second fraction: ");
            s.Denominator = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The first fraction is: ");
            f.Print();
            Console.WriteLine("The second fraction is: ");
            s.Print();
            
  
            Console.WriteLine("The sum of the two fractions is: ");
            f.Add(f, s);
            Console.WriteLine("The difference of the two fractions is: ");
            f.Subtract(f, s);
            Console.WriteLine("The product of the two fractions is: ");
            f.Multiply(f, s);
            Console.WriteLine("The quotient of the two fractions is: ");
            f.Divide(f, s);
            Console.WriteLine("The decimal value of the first fraction is: ");
            f.Decimal(f, s);
        }
    }
}
