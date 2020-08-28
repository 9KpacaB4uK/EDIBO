using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Net.WebSockets;
using System.Threading;
using WebSocketServer.Middleware;

namespace WebSocketServer
{
    public class Startup
    {
        public void WriteRequestParam(HttpContext context, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
            Console.WriteLine("Request Method: " + context.Request.Method);
            Console.WriteLine("Request Protocol: " + context.Request.Protocol);

                if (context.Request.Headers != null)
                {
                    Console.WriteLine("Request Headers: ");
                    foreach (var h in context.Request.Headers)
                    {
                    Console.WriteLine("--> " + h.Key + ": " + h.Value);
                    }
                }
            }
        }
        public void ConfigureServices(IServiceCollection services)
        {
              services.AddWebSocketServerConnectionManager();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseWebSockets();
            app.UseWebSocketServer();
            app.Run(async context =>
            {
                Console.WriteLine("Hello from 3rd (terminal) Request Delegate");
                await context.Response.WriteAsync("Hello from 3rd (terminal) Request Delegate");
            });
        }
        private async Task ReceiveMessage(WebSocket socket, Action<WebSocketReceiveResult, byte[]> handleMessage)
        {
        var buffer = new byte[1024 * 4];

        while (socket.State == WebSocketState.Open)
            {
                var result = await socket.ReceiveAsync(buffer: new ArraySegment<byte>(buffer),
                                                                cancellationToken: CancellationToken.None);
                handleMessage(result, buffer);
            }
        }
        
    }
}
