using System;
using System.Threading;

namespace _01_Thread_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating - Using Threads - Start");
            DateTime dtSt = DateTime.Now;
            Console.WriteLine("Two activities without using thread - Start");
            Program.DoSomethingHeavy();
            Program.DoSomething();
            Console.WriteLine("Two activities without using thread - Done");
            DateTime dtEd = DateTime.Now;
            TimeSpan tsSpent = dtEd - dtSt;
            Console.WriteLine($"It took {tsSpent.TotalSeconds} seconds");
            dtSt = DateTime.Now;
            Console.WriteLine("Again those two activities using threads - Start");
            Thread thrd1 = new Thread(new ThreadStart(Program.DoSomethingHeavy));
            Thread thrd2 = new Thread(new ThreadStart(Program.DoSomething));
            thrd1.Start();
            thrd2.Start();
            // Suggestion 1: Comment this two lines below to see different outcome
            // Compare different result of Suggestion 1 / 02-TaskBasic
            thrd1.Join();
            thrd2.Join();
            Console.WriteLine("Two activities using threads - Done");
            dtEd = DateTime.Now;
            tsSpent = dtEd - dtSt;
            Console.WriteLine($"It took {tsSpent.TotalSeconds} seconds");
            Console.WriteLine("Demonstrating - Using Threads - Done");
        }
        public static void DoSomethingHeavy()
        {
            Console.WriteLine("DoSomethingHeavy - Start");
            Thread.Sleep(1000);
            Console.WriteLine("DoSomethingHeavy - Step 1");
            Thread.Sleep(1000);
            Console.WriteLine("DoSomethingHeavy - Step 2");
            Thread.Sleep(1000);
            Console.WriteLine("DoSomethingHeavy - Step 3");
            Thread.Sleep(1000);
            Console.WriteLine("DoSomethingHeavy - Done");
        }
        public static void DoSomething()
        {
            Console.WriteLine("DoSomething - Start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"DoSomething Setp - {i}");
                Thread.Sleep(280);
            }
            Console.WriteLine("DoSomething - Done");
        }
    }
}
