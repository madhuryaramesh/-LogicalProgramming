using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class Prime
    {
        public void Pri()
        {
            Console.Write("ENTER A NUMBER : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int j=0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    j++;
                }
            }
            if (j == 2)
            {
                Console.WriteLine("IS PRIME NUMBER" +num);
            }
            else
            {
                Console.WriteLine("NOT PRIME NUMBER");
            }
            Console.ReadLine();
        }
    }
}
