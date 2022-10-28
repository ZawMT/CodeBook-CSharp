using System;
using System.ComponentModel.Composition;

namespace _04_MEF_Opt.App
{
    /*
     * If there is any error saying 'The export is not assignable to ... ', 
     * then make sure that Export is correctly done (the line is applied to class level - not function) 
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OptContainer optC = new OptContainer();
                optC.Opt.OptFunction();
            }
            catch(Exception x)
            {
                Console.WriteLine("Error in testing MEF: " + x.ToString());
            }
        }
    }
}
