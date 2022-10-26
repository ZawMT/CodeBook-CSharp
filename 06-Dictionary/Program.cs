using System;
using System.Collections.Generic;

namespace _06_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dTest = new Dictionary<String, String>();
            dTest["Test"] = "Try to do an activity to know what the outcome will be";
            dTest["Home"] = "An accommodation where a group of people stays together";
            dTest["Apple"] = "A fruit which was eaten by Eve";
            dTest["Game"] = "Something to play for a person or a group of people";
            Console.WriteLine("Printing the dictionary");
            Console.WriteLine("=======================");
            foreach (KeyValuePair<String, String> entry in dTest)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.WriteLine(Environment.NewLine);
            SortedDictionary<String, String> dTestSorted = new SortedDictionary<String, String>(dTest);
            Console.WriteLine("Printing the dictionary in order");
            Console.WriteLine("================================");
            foreach (KeyValuePair<String, String> entry in dTestSorted)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
