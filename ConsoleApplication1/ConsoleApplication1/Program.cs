using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] mas = new int[len];
            int max = 0;
            for (int f = 0; f < len; f++)
            {
                mas[f] = int.Parse(Console.ReadLine());
                if (mas[f] > max) max = mas[f];
            }

            foreach (long i in mas)
            {
                double ig = (Math.Sqrt(8 * i - 7)) % 1;
                if (ig == 0) Console.Write("1 ");
                else Console.Write("0 ");
                Console.ReadLine();
            }


        }
    }
}
