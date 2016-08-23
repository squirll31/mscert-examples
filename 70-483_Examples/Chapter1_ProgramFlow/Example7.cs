using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example7
    {
        public static void Run(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from a threadpool!");
            });
            Console.ReadLine();
        }
    }
}
