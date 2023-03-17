using System;
using System.Threading;

namespace _15_CS_DateTime
{    enum Test
    {
        TEST1, TEST2, TEST3
    };

    class Program
    {
        static bool fnCheckIfOk(DateTime dt)
        {
            return dt != DateTime.MinValue;
        }
        static void Main(string[] args)
        {
            Test tst = Test.TEST1;
            Console.WriteLine(tst);
            Console.WriteLine(nameof(tst));
            Console.WriteLine(nameof(Test.TEST2));

            string strT3 = nameof(Test.TEST3);
            Test tst2; 
            Enum.TryParse(strT3, out tst2); // From string to Enum
            Console.WriteLine(nameof(tst));
            Console.WriteLine(Enum.GetName(typeof(Test), tst2)); //From Enum to string

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

            //Checking data types
            object obj;
            string str1 = "TEST";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(typeof(string));
            obj = str1;
            Console.WriteLine(obj.GetType());
            obj = 3;
            Console.WriteLine(obj.GetType());
            obj = 3.5;
            Console.WriteLine(obj.GetType());
        }
    }
}
