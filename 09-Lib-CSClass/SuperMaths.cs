using System;

namespace _09_Lib_CSClass
{
    /*
     * This project's target framework is .Net Core which is the implementation of .Net Standard.
     * 
     * This project cannot be referred (cannot be added as a reference) in the 09-UseApp (.Net Framewrok Application).
     * In fact, this project is not in use at all.
     * This project is left here to highlight the point, and to try out and see, that .Net Core DLL cannot be referred from .Net Framework project.
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
