using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qw1
{

    class main
    {
        static void Main(string[] args)
        {

         

            List<long> ans = new List<long>();

            long s = System.Int64.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ans.Add(Find(x));
            }

            for (int i = 0; i < s; i++)
            {
                Console.Write(ans[i]);
                Console.Write(" ");
            }



          
        }

        static long Find(long x)
        {

            // (a)n^2 + (b)n - (c)2x = 0
            // a = 1
            // b = 1
            // c = 2 * x

            double a = 1, b = 1, c = -2 * x + 2;
            double d = b * b - 4 * a * c;
            double p = (-b + Math.Sqrt(d)) / 2 * a;

            return (p - (long)p) > 0 ? 0 : 1;

        }

    }
}