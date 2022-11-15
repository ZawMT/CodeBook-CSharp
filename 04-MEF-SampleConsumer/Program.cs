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
                /*
                 * While importing the implemented plugins, sometimes there can be errors showing System.IO.FildNotFoundException
                 * although the DLL file to be imported is there.
                 * It can happen when the implemented library uses some other third party library (e.g. Newtonsoft.Json) 
                 * and the importer cannot file that DLL. 
                 * In that case, just add in the required library (in this example, Newtonsoft.Json) in the reference of this consumer project.
                 * 
                 * One additional note: To find out the detail info of an exception, in this example System.IO.FildNotFoundException,
                 * go to 'Debug' -> 'Windows' -> 'Exception Settings' -> 'Common Language Runtime Exceptions' 
                 * Then click the System.IO.FileNotFoundException 
                 * This will give the further / detail info of the error
                 */
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
