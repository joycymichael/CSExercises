﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SQUARE ROOT OF DOUBLE PRECISION NEMBER");
            Console.Write("Enter a number : ");
            double d = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(d);
            Console.WriteLine("SQUARE ROOT = " + c);
            Console.ReadLine();
        }
    }
}
