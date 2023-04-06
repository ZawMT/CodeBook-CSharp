using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    /*
     * To test this code, you will need a database (at least one table) set up and exposed it through GraphQL service 
     * Using https://cloud.hasura.io/ will be a fast approach
     */

    public const string strSecretKey = "SecretKey";
    public const string strAddress = "gql-test.hasura.app/v1/graphql";
    static async Task Main(string[] args)
    {
        try
        {
            var subscriptionUri = new Uri($"wss://{strAddress}");

            using (var webSocket = new ClientWebSocket())
            {
                webSocket.Options.SetRequestHeader("x-hasura-admin-secret", strSecretKey);
                webSocket.Options.AddSubProtocol("graphql-ws");
                // This doesn't work => webSocket.Options.SetRequestHeader("Sec-WebSocket-Protocol", "graphql-ws");

                await webSocket.ConnectAsync(subscriptionUri, CancellationToken.None);

                var connectionInit = new
                {
                    type = "connection_init",
                    payload = new { }
                };

                var bufConnInit = new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(connectionInit)));
                await webSocket.SendAsync(bufConnInit, WebSocketMessageType.Text, true, CancellationToken.None);
                string strConnInit = Encoding.UTF8.GetString(bufConnInit.Array, 0, bufConnInit.Count);

                var subscriptionRequest = new
                {
                    id = "1",
                    type = "start",
                    payload = new
                    {
                        query = @"subscription GetttTbLoginStreamingSubscription { tb_login { login_user login_time } }"
                    }
                };

                var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(subscriptionRequest)));
                await webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);

                while (webSocket.State == WebSocketState.Open)
                {
                    buffer = new ArraySegment<byte>(new byte[1024]);

                    var result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string strRead = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                        Console.WriteLine("================================");
                        Console.WriteLine(strRead);
                        Console.WriteLine("================================");
                    }
                }

                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
            }
        }
        catch(Exception x)
        {
            Console.WriteLine(x.Message);
            if (x.InnerException != null)
                Console.WriteLine(x.InnerException.Message);
        }
    }
}
