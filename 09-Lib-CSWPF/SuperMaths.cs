using System;

namespace _09_Lib_CSWPF
{
    public class SuperMaths
    {
        public string Add(string s1, string s2, bool bUseParam1AsItIs = false, bool bUseParam2AsItIs = false)
        {
            string strRet = s1 + s2;
            if (bUseParam1AsItIs && bUseParam2AsItIs)
                return strRet;
            return strRet;
        }
    }
}
