﻿using System;
using System.Linq;
using System.Text;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, p = 0;
            x = int.Parse(Console.ReadLine());

            if (x < 0 && x >= -10000)
            {
                for (int i = x; i <= 1; i++)
                    p += i;
            }
            else if (x > 0 && x <= 10000)
            {
                for (int i = 1; i <= x; i++)
                    p += i;
            }
            else
                p = 1;

            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}