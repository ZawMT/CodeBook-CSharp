using Npgsql;
using System;

namespace _18_CS_AwsPostgres
{
    class Program
    {
        static void Main(string[] args)
        {
            /* First set up a Postgre DB in AWS and change the info below according to that set up */
            string strHost = "awsrds.c1socxsguyfa.us-east-1.rds.amazonaws.com";
            // string strPort = "5432"; // If port is 5432 (default port), then it is optional in the connection string
            string strDb = "database1";
            string strUser = "postgres";
            string strPwd = "Post2022";

            try
            {
                string connString = $"Server={strHost};Database={strDb};User Id={strUser};Password={strPwd};SslMode=Require;Trust Server Certificate=true;";
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                Console.WriteLine("Connected to database!");
                // do some work with the connection
                conn.Close();
                Console.WriteLine("Disconnected from database!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
