using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using System;

namespace _20_CS_AwsSnsPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            string strAccessKey = "AccessKey";
            string strSecretKey = "SecretKey";

            // Set up the AWS credentials and region
            var credentials = new Amazon.Runtime.BasicAWSCredentials(strAccessKey, strSecretKey);
            var region = RegionEndpoint.APSoutheast1;

            // Create an instance of the Amazon SNS client
            var snsClient = new AmazonSimpleNotificationServiceClient(credentials, region);

            // Publish a message to an SNS topic
            bool bDone = true;
            do 
            {
                Console.WriteLine("Type X to quit or other to publis a message:");
                string strMsg = Console.ReadLine();
                if (strMsg.ToLower().CompareTo("x") == 0)
                    bDone = true;
                else
                    bDone = false;

                var request = new PublishRequest
                {
                    TopicArn = "arn:aws:sns:ap-southeast-1:512886573183:TopicVI",
                    Message = strMsg
                };

                var response = snsClient.PublishAsync(request);
            } while (!bDone);          
        }
    }
}
