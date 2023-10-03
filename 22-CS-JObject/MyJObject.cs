using Newtonsoft.Json.Linq;
using System;

namespace _22_CS_JObject
{
    class MyJObject
    {
        private JObject jObj = null;
        private string strStatus = "";
        private bool bValid = false;
        
        public bool Valid { get { return bValid; } }
        
        public string Status { get { return strStatus; } }
        
        public MyJObject(string strJson)
        {
            try
            {
                jObj = JObject.Parse(strJson);
                bValid = true;
            }
            catch(Exception x)
            {
                strStatus = x.Message;
                if (x.InnerException != null)
                    strStatus = strStatus + " => " + x.InnerException.Message;

                bValid = false;
            }

            // In case
            if (jObj == null)
                bValid = false;
        }

        public MyJObject(JObject jObject)
        {
            jObj = jObject;
            bValid = true;
            if (jObj == null)
            {
                bValid = false;
                strStatus = "Null JObject was used in instantiating";
            }
        }

        public override string ToString()
        {
            if (bValid && jObj!=null)
            {
                return jObj.ToString();
            }

            return "";
        }

        public MyJObject GetMyJObject(string strPath, out bool bError)
        {
            MyJObject myJObj = new MyJObject("");
            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.ToString().CompareTo("Object") == 0)
                    {
                        JObject objRet = jToken.Value<JObject>();
                        return new MyJObject(objRet);
                    }
                }
                else
                    bError = true;
            }
            else
                bError = true;

            return myJObj;
        }

        public JObject GetObject(string strPath, out bool bError)
        {
            JObject objRet = null;
            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.ToString().CompareTo("Object") == 0)
                        objRet = jToken.Value<JObject>();
                }
                else
                    bError = true;
            }
            else
                bError = true;

            return objRet;
        }

        public string GetString(string strPath, out bool bError)
        {
            string strRet = "";
            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.ToString().CompareTo("String") == 0)
                        strRet = jToken.Value<string>();
                }
                else
                    bError = true;
            }
            else
                bError = true;

            return strRet;
        }

        public int GetInteger(string strPath, out bool bError)
        {
            int iRet = -1;

            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.GetType() == typeof(int))
                        iRet = jToken.Value<int>();
                    else if (jToken.Type.ToString().CompareTo("String") == 0)
                    {
                        if (!int.TryParse(jToken.Value<string>(), out iRet))
                            bError = true;
                    }
                    else
                        bError = true;
                }
            }
            else
                bError = true;

            return iRet;
        }

        public bool GetBoolean(string strPath, out bool bError)
        {
            bool bRet = false;

            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.GetType() == typeof(bool))
                        bRet = jToken.Value<bool>();
                    else if (jToken.Type.ToString().CompareTo("String") == 0)
                    {
                        if (!bool.TryParse(jToken.Value<string>(), out bRet))
                            bError = true;
                    }
                    else
                        bError = true;
                }
            }
            else
                bError = true;

            return bRet;
        }

        public DateTime GetDateTime(string strPath, out bool bError)
        {
            DateTime dtRet = DateTime.MinValue;

            if (bValid)
            {
                bError = false;
                JToken jToken = jObj.SelectToken(strPath);
                if (jToken != null)
                {
                    if (jToken.Type.ToString().CompareTo("Date") == 0)
                    {
                        dtRet = jToken.Value<DateTime>();
                    }
                    else if (jToken.Type.ToString().CompareTo("String") == 0)
                    {
                        if (!DateTime.TryParse(jToken.Value<string>(), out dtRet))
                            bError = true;
                    }
                    else
                        bError = true;
                }
            }
            else
                bError = true;

            return dtRet;
        }
    }
}
