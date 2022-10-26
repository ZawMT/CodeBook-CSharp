using System;

namespace _05_PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // The information in this chapter is quite straightforward and descriptive.
            // When a class is too large, we can create separate files to have the following benefits or alike:
            // 1: To organize the functions separately for better readability
            // 2: Each developer can work separately on the different functions of the same class
            ClassTest clsTst = new ClassTest();
            clsTst.fnTest();
            clsTst.fnTest1();
            clsTst.fnTest2();
        }
    }
}
