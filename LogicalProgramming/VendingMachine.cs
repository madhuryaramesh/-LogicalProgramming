using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class VendingMachine
    {
        public void Machine()
        {

			// Static Variables i for indexing the array and total for calculating the total Notes
		     int i = 0;
			 int total = 0;

			//Initialization of New Array
			 int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
		     int money;

			Console.WriteLine("Enter the Amount:");
			money = int.Parse(Console.ReadLine());

			// Function for Calculating the notes
			int calculate(int money, int[] notes)
			{
				
				//calling calculate Function
				int rem;
				if (money == 0)
				{
					return -1;
				}
				else
				{
					if (money >= notes[i])
					{
						// logic for Calculating The notes
						int calNotes = money / notes[i];
						rem = money % notes[i];
						money = rem;
						total += calNotes;
						Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
						Console.WriteLine("Total Number of Notes are :" + total);
						//System.out.println(notes[i] + " Notes ---> " + calNotes);
					}
					i++;
					return calculate(money, notes);
				}
				//Console.WriteLine("Total Number of Notes are :" + total);
			}//end of method
		}
    }
}
