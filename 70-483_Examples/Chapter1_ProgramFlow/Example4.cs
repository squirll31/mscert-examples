using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example4
    {
        public static void Run(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            })
            );

            t.Start();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }

    }
}
