using System;

namespace _10_GetterSetter
{
    /*
     * This chapter is a very easy and simple test utilising the shorthand feature of C# (in this example: get, set and new)
     * Further reading: C# contextual keywords
     * */
    class TestClass
    {
        private int iMember;
        public int IntMember { get; set; }

        private string strMember;
        public string StringMember { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new();
            testClass.IntMember = 100;
            testClass.StringMember = "One hundred";
            Console.WriteLine("{0} : {1}", testClass.IntMember, testClass.StringMember);
        }
    }
}
