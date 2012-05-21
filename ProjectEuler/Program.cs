using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Problems;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch Timer = new Stopwatch();

            Timer.Start();
            p010.Solve();
            Timer.Stop();
            Console.WriteLine("Running time: {0}", Timer.Elapsed);
        }
    }
}
