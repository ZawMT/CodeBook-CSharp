using System;
using System.Threading;

namespace _15_CS_DateTime
{
    class Program
    {
        static bool fnCheckIfOk(DateTime dt)
        {
            return dt != DateTime.MinValue;
        }
        static void Main(string[] args)
        {
            DateTime dtTest = DateTime.MinValue;
            Console.WriteLine(dtTest.ToString("yyyy-MM-dd HH:mm:ss.FFF"));
            dtTest = DateTime.MinValue;
            Console.WriteLine(dtTest.ToString("yyyy-MM-dd HH:mm:ss.FFF"));
            dtTest = DateTime.MinValue;
            Console.WriteLine(dtTest.ToString("yyyy-MM-dd HH:mm:ss.FFF"));            
            Console.WriteLine(fnCheckIfOk(dtTest));
            Console.WriteLine(fnCheckIfOk(DateTime.UtcNow));
            Thread.Sleep(2500);
            Console.WriteLine(fnCheckIfOk(dtTest));
            Console.WriteLine(fnCheckIfOk(DateTime.UtcNow));
        }
    }
}
