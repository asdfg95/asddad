using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qw2
{
    class Program
    {

        static void Main(string[] args)
        {
            double Result = 0;
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] arr = numbers.ToArray();

            Array.Sort(arr);
            double numbOfGroups = Math.Ceiling(arr.Length / 2.0);

            for (int i = 0; i < numbOfGroups; ++i)
            {
                Result += (Math.Ceiling(arr[i] / 2.0));
            }
            Console.WriteLine(Result);
            Console.ReadLine();
        }

    }
}
