﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10,
                y = 20,
                z = 30;

            int age = 23;

            Console.WriteLine(age);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.20;
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.000001F;
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            Console.ReadLine();
        }
    }
}
