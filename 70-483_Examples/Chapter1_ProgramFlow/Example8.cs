using System;
using System.Threading.Tasks;

namespace Chapter1_ProgramFlow
{
    class Example8
    {
        public static void Run(string[] args)
        {

            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });
            t.Wait();
        }
    }
}
