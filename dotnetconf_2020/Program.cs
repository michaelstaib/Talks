﻿using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake.Transport.WebSockets;

namespace Client
{
    public class Program
    {
        private static readonly string _token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pY2hhZWxAY2hpbGxpY3JlYW0uY29tIiwiZW1haWwiOiJtaWNoYWVsQGNoaWxsaWNyZWFtLmNvbSIsIkNoYXQuVXNlcklkIjoiODA4YTE1MGYtNDliOC00MjFhLTgxNGEtZmRkMjlmMzYxZTg2IiwibmJmIjoxNjA1MTY2MzIyLCJleHAiOjE2MDUyMDk1MjIsImlhdCI6MTYwNTE2NjMyMn0.RGG9h1v4l6CBvfgFG9x6dSlx4j3xU3heHFgrVW2Br_0";

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient(
                "ChatClient",
                (services, client) =>
                {
                    client.BaseAddress = new Uri("https://hotchocolate-chat.azurewebsites.net");
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("bearer", _token);
                });

            builder.Services.AddWebSocketClient(
                "ChatClient",
                (service, client) => 
                {
                    client.Uri = new Uri("wss://hotchocolate-chat.azurewebsites.net?token=" + _token);
                });

            builder.Services.AddChatClient();

            await builder.Build().RunAsync();
        }
    }
}
