using System;
using System.Threading;

namespace Chapter1_ProgramFlow
{
    class Example5
    {
        [ThreadStatic]
        public static int _field;

        public static void Run(string[] args)
        {
            // Max count should be 10, _field is static
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}