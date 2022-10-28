using System;
using System.ComponentModel.Composition;

namespace _04_MEF_Opt.Opt1
{
    /*
     * This is the second project in the series about MEF. 
     * 
     * This is one available option for the final applicatoin to use.
     * Here the key points to take note or lookp up are:
     * 1: System.ComponentModel.Composition which can be installed using NuGet. The library is required to implement this MEF facility.
     * 2: [Export(typeof(IOpt))] => This code line is for exporting the class to be available in the application (which will consume it).
     * Writing this line Export over the function declaration will not give any error but there will be runtime error while using it finally, and it is a common mistake.
     */
    [Export(typeof(IOpt))]
    public class OptClass1 : IOpt
    {
        public void OptFunction()
        {
            Console.WriteLine("This is OptClass 1 UN ONE Yi Ichi Hana running");
        }
    }
}
