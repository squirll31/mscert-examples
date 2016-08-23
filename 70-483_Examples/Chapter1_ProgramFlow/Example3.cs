using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example3
    {
        private static void ThreadMethod(object o)
        {
            for (int x = 0; x < (int)o; x++)
            {
                Console.WriteLine("ThreadMethod: {0}", x);
                Thread.Sleep(0);
            }
        }

        public static void Run(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
            Console.ReadLine();
        }
    }
}
