using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Testing starts");
        try
        {
            // Create an instance of AmazonSimpleNotificationServiceClient
            string strAccessKey = "AKIAXO2TMBB7TDPPAH56";
            string strSecretKey = "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";
            var snsClient = new AmazonSimpleNotificationServiceClient(strAccessKey, strSecretKey, Amazon.RegionEndpoint.APSoutheast1);

            // Create an instance of AmazonSQSClient
            var sqsClient = new AmazonSQSClient(strAccessKey, strSecretKey, Amazon.RegionEndpoint.APSoutheast1);

            // Create an SQS queue to receive the SNS messages
            var queueResponse = sqsClient.CreateQueueAsync("QueueVI").Result;
            var queueUrl = queueResponse.QueueUrl;

            // Subscribe to the SNS topic using the SQS queue as the notification endpoint
            var subscribeRequest = new SubscribeRequest
            {
                Protocol = "sqs",
                TopicArn = "arn:aws:sns:ap-southeast-1:512886573183:TopicVI",
                Endpoint = "arn:aws:sqs:ap-southeast-1:512886573183:QueueVI"
            };

            var subscribeResponse = await snsClient.SubscribeAsync(subscribeRequest);

            // Receive and process the SNS messages from the SQS queue
            while (true)
            {
                var receiveMessageRequest = new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    MaxNumberOfMessages = 10,
                    WaitTimeSeconds = 20 // Long polling
                };

                var receiveMessageResponse = await sqsClient.ReceiveMessageAsync(receiveMessageRequest);

                foreach (var message in receiveMessageResponse.Messages)
                {
                    // Process the SNS message
                    Console.WriteLine(message.Body);

                    // Delete the message from the queue
                    var deleteMessageRequest = new DeleteMessageRequest
                    {
                        QueueUrl = queueUrl,
                        ReceiptHandle = message.ReceiptHandle
                    };
                    await sqsClient.DeleteMessageAsync(deleteMessageRequest);
                }
            }

        }
        catch (Exception x)
        {
            Console.WriteLine("Error and quit!!!");
            Console.WriteLine(x.Message);
            if(x.InnerException != null)
                Console.WriteLine(x.InnerException.Message);
        }

        Console.WriteLine("Bye bye!");
    }
}