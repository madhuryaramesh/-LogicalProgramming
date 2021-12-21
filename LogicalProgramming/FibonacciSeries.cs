using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class FibonacciSeries
    {
        public void FibSer()
        {
            int num1 = 0, num2 = 1, num3, i, n;
            Console.Write("ENTER THE LIMIT OF NUMBERS TO PRINT: ");
            n = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " "); //printing 0 and 1    
            for (i = 2; i < n; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                num3 = num1 + num2;
               // Console.Write(num3 + " ");
                Console.Write("{0} ", num3);
                num1 = num2;
                num2 = num3;

            }

        }
    }
}
