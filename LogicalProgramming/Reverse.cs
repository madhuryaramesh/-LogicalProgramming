using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class Reverse
    {
        public void Rever()
        {
			int num, rev=0;
			int reverse = 0;

			Console.WriteLine("ENTER THE NUMBER : ");
			num = int.Parse(Console.ReadLine());

			while (num > 0)
			{
				rev = rev * 10 + num % 10;
				num = num / 10;
			}

			Console.WriteLine("Reversed number is : {0}", rev);
		}
    }
}
