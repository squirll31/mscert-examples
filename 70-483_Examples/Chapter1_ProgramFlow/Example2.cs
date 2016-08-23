using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example2
    {
        private static void ThreadMethod()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ThreadMethod: {0}", x);
                Thread.Sleep(1000);
            }
        }

        public static void Run(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            t.IsBackground = true;
            t.Join();
            Console.ReadLine();
        }
    }
}
