using System;

namespace _09_Lib_CSClass
{
    /*
     * This project's target framework is .Net Core which is the implementation of .Net Standard.
     * 
     * This project cannot be referred (cannot be added as a reference) in the 09-UseApp (.Net Framewrok Application).
     * In fact, this project is not in use at all.
     * This project is left here to highlight the point, and to try out and see, that .Net Core DLL cannot be referred from .Net Framework project.
     * 
     * This series (09) is to test, check and demonstrate the fact that different DLL types can impose some difficulties in using
     * different types of project. So before starting on a project, this should be chosen or lined up carefully first.
     * Even when the library is usable, it might require some tweaks.
     * 
     * In this series, WPF project can consume all the DLLs.
     * 
     * Regarding to using 32 bit DLL in 64 bit projects, it is a tricky topic as well.
     * Roughly a wrapper class might be needed. This might need to a separate series.
     * */
    public class SuperMaths
    {
        public string Add(string s1, string s2, bool bUseParam1AsItIs = false, bool bUseParam2AsItIs = false)
        {
            string strRet = s1 + s2;
            return strRet;
        }
    }
}
