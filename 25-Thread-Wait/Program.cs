using System;
using System.Threading;
using System.Threading.Tasks;

namespace _25_Thread_Wait
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = Task.Run(async () =>
            {
                Task<int> task1 = Task.Run(() =>
                {
                    Random random = new Random();
                    int iRet = random.Next(1, 200);
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Task 1: {i}");
                        Thread.Sleep(500);
                        iRet = random.Next(1, 200);
                    }

                    return iRet;
                });

                Task<int> task2 = Task.Run(() =>
                {
                    Random random = new Random();
                    int iRet = random.Next(201, 500);
                    for (int i = 0; i < 8; i++)
                    {
                        Console.WriteLine($"Task 2: {i}");
                        Thread.Sleep(1000);
                        iRet = random.Next(201, 500);
                    }

                    return iRet;
                });

                Task<int> task3 = Task.Run(() =>
                {
                    Random random = new Random();
                    int iRet = random.Next(1, 500);
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Task 3: {i}");
                        Thread.Sleep(250);
                        iRet = random.Next(1, 500);
                    }

                    return iRet;
                });

                await Task.WhenAll(task1, task2); // All the statements after this line will not be run until the two tasks are finished
                int n1 = task1.Result;
                int n2 = task2.Result;
                await Task.WhenAll(task3);
                int n3 = task3.Result;
                return (n1, n2, n3);

            }).Result;

            Console.WriteLine($"Return1 => {ret.n1} Return2 => {ret.n2} Return3 => {ret.n3}");
        }
    }
}
