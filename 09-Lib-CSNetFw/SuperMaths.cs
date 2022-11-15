using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Lib_CSNetFw
{
    /*
     * Just a test class though I give it a very special name. :D 
     */
    public class SuperMaths
    {
        public string Add (string s1, string s2, bool bUseParam1AsItIs = false, bool bUseParam2AsItIs = false)
        {
            string strRet = s1 + s2;
            if (bUseParam1AsItIs && bUseParam2AsItIs)
                return strRet;
            return strRet;
        }
    }
}
