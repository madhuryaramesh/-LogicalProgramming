using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class Coupon
    {
        public void Cou()
        {
            Console.WriteLine("ENTER THE LIMIT : ");
            int n = int.Parse(Console.ReadLine());
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[n];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            Console.WriteLine(finalString);
        }
    }
}