using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int num, sum = 0, n;
            Console.Write("ENTER THE NUMBER : \n");
            num = int.Parse(Console.ReadLine());
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n IS PERFECT NUMBER");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n IS NOT PERFECT NUMBER");
                Console.ReadLine();
            }
        }
    }
}
