using Newtonsoft.Json.Linq;
using System;

namespace _22_CS_JObject
{
    class Program
    {
        // This test application is just to try and see the nature of JObject of NewtonSoft
        static void Main(string[] args)
        {
            string strJson = "{ \"type\":\"ka\"}";
            JObject jObj = JObject.Parse(strJson);

            strJson = "{ \"type\":\"data\",\"id\":\"1\",\"payload\":{ \"data\":{ \"tb_login\" : [{ \"login_user\":1,\"login_time\":\"2023-04-20T06:59:45.702897+00:00\"}]} } }";
            jObj = JObject.Parse(strJson);
            Console.WriteLine(jObj["type"]);
            Console.WriteLine(jObj["id"]);
            Console.WriteLine(jObj["payload"]);

            JObject jObjDet = (JObject) jObj["payload"];
            Console.WriteLine(jObjDet["data"]);
            JObject jObjRows = (JObject)jObj["data"];

            MyJObject myjo = new MyJObject("{ \"type\":\"data\",\"id\":\"1\",\"payload\":{ \"data\":{ \"tb_login\" : [{ \"login_user\":1,\"login_time\":\"2023-04-20T06:59:45.702897+00:00\"}]} } }");
            Console.WriteLine(myjo.GetString("type", out _));
            Console.WriteLine(myjo.GetString("id", out _));
            Console.WriteLine(myjo.GetInteger("id", out _));
            Console.WriteLine(myjo.GetObject("payload", out _));
            Console.WriteLine(myjo.GetObject("payload.data", out _));
            Console.WriteLine(myjo.GetDateTime("payload.data.tb_login[0].login_time", out _));
            Console.WriteLine(myjo.GetMyJObject("payload", out _).ToString());
        }
    }
}