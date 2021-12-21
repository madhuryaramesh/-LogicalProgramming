using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    public class StopWatchTime
    {
        public void Time()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Do something
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
            }

            stopwatch.Stop();

            // Write result
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
