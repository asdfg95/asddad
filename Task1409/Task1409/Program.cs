﻿using System;
using System.Linq;
using System.Text;

namespace Two_Gangsters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] x = s.Split(' ');
            int H = Convert.ToInt32(x[0]);
            int L = Convert.ToInt32(x[1]);

            Console.WriteLine((L - 1) + " " + (H - 1));

            Console.ReadLine();
        }
    }
}
