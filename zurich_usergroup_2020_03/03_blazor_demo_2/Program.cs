﻿using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake.Transport.WebSockets;

namespace Client
{
    public class Program
    {
        private static readonly string _token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pY2hhZWxAY2hpbGxpY3JlYW0uY29tIiwiZW1haWwiOiJtaWNoYWVsQGNoaWxsaWNyZWFtLmNvbSIsIkNoYXQuVXNlcklkIjoiODA4YTE1MGYtNDliOC00MjFhLTgxNGEtZmRkMjlmMzYxZTg2IiwibmJmIjoxNTkzNDQzMTE4LCJleHAiOjE1OTM0ODYzMTgsImlhdCI6MTU5MzQ0MzExOH0.YHQ3FT_eUZlazk-Iurd5y0Bkpt0-URk1_6sQvkhKTug";

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddHttpClient(
                "ChatClient",
                (services, client) =>
                {
                    client.BaseAddress = new Uri("https://hotchocolate-chat.azurewebsites.net");
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("bearer", _token);
                });

            builder.Services.AddChatClient();

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
