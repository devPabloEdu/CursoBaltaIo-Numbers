﻿using System;
using System.Globalization;
namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;
            //Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-Br")));
            //Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));

        }
    }
}