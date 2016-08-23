using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example1
    {
        private static void ThreadMethod()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ThreadMethod: {0}", x);
                Thread.Sleep(0);
            }
        }

        public static void Run(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Main: {0}", x);
                Thread.Sleep(0);
            }

            t.Join();
            Console.ReadLine();
        }
    }
}
