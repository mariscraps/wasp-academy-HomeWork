using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace TakeawayFastFood
{
    class Program
    {
        private DiscordSocketClient _client;
        static void Main(string[] args)
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        public async Task MainAsync()
        {
            using (var services = ConfigureServices())
            {
                _client = services.GetRequiredService<DiscordSocketClient>();

                _client.Log += LogAsync;
                services.GetRequiredService<CommandService>().Log += LogAsync;

                await _client.LoginAsync(TokenType.Bot, "token");
                await _client.StartAsync();

                await services.GetRequiredService<CommandServiceHandler>().InitializeAsync();

                await Task.Delay(Timeout.Infinite);
            }
        }

        private Task LogAsync(LogMessage arg)
        {
            Console.WriteLine(arg.ToString());
            return Task.CompletedTask;
        }

        private ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton<CommandService>()
                .AddSingleton<CommandServiceHandler>()
                .AddSingleton<HttpClient>()
                .BuildServiceProvider();
        }
    }

}
