using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int fac = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);

                for (int i = 1; fac < n; i++)
                {
                    fac = fac * i;
                }

            }
            Console.WriteLine(" = " + sum);
            Console.WriteLine(sum);
            Console.WriteLine(" = " + fac);
        }
    }
}
