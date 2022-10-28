using System;
using System.ComponentModel.Composition;

namespace _04_MEF_Opt.Opt2
{
    [Export(typeof(IOpt))]
    public class OptClass2 : IOpt
    {        
        public void OptFunction()
        {
            Console.WriteLine("This is OptClass 2 TWO Deux Ni Er running!!!");
        }
    }
}
