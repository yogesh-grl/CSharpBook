using System.Net.WebSockets;
using System.Text;

namespace WebAppSample.Helper
{
    public class WebSocketHandler
    {
        public static async Task HandleWebSocketRequest(HttpContext context)
        {
            if (context.WebSockets.IsWebSocketRequest)
            {
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                var buffer = new byte[1024 * 4];

                while (webSocket.State == WebSocketState.Open)
                {
                    // Receive message from client
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var query = context.Request.Query;
                        var type = query["type"];

                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        Console.WriteLine($"Received message: {message}");

                        // Process or echo the message
                        var responseMessage = $"Echo: {message}";
                        await SendMessageAsync(webSocket, responseMessage);
                    }
                    else if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by client", CancellationToken.None);
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                context.Response.StatusCode = 400;
            }
        }

        private static async Task SendMessageAsync(WebSocket webSocket, string message)
        {
            var messageBuffer = Encoding.UTF8.GetBytes(message);
            await webSocket.SendAsync(new ArraySegment<byte>(messageBuffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }

}
