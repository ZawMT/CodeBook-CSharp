using System;
using System.Collections.Generic;

namespace _26_ListObjParam_DeepOrShallow
{
    class Person
    {
        private string strName = "";
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        private int iAge = 0;
        public int Age
        {
            get { return iAge; }
            set { iAge = value; }
        }

        public Person(string strNm, int Ag)
        {
            strName = strNm;
            iAge = Ag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lstPs = new List<Person>();
            lstPs.Add(new Person("John", 12));
            lstPs.Add(new Person("Jane", 23));
            lstPs.Add(new Person("Janet", 34));
            lstPs.Add(new Person("Jeanne", 55));
            lstPs.Add(new Person("Jill", 78));
            fnPrint(lstPs);
            fnTest1(lstPs);
            fnPrint(lstPs);
            fnTest2(lstPs);
            fnPrint(lstPs);
        }

        static void fnTest1(List<Person> lstParam)
        {
            foreach(Person p in lstParam)
            {
                p.Age = p.Age + 1;
            }
        }

        static void fnTest2(List<Person> lstParam)
        {
            List<string> lstNamesToRemove = new();
            foreach (Person p in lstParam)
            {
                if (p.Age % 2 == 0)
                    lstNamesToRemove.Add(p.Name);
            }

            lstParam.RemoveAll(p => lstNamesToRemove.Contains(p.Name));
        }

        static void fnPrint(List<Person> lstParam)
        {
            Console.WriteLine($"Printing list of {lstParam.Count} items");
            foreach (Person p in lstParam)
                Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}
