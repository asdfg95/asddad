using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qw1
{

    class main
    {
        public static void Main()
        {
            int n, i, c, j, l; string rez = ""; string t = "";
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                c = Convert.ToInt32(Console.ReadLine());
                t = "1";
                l = t.Length;
                for (j = 1; l <= c; j++)
                {
                    t = t + Convert.ToString(Math.Pow(10, j));
                    l = t.Length;
                }
                rez = rez + t[c - 1] + " ";
            }
            Console.WriteLine(rez);
            Console.ReadLine();
        }

    }
}