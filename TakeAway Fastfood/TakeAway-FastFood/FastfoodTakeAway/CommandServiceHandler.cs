using System;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace TakeawayFastFood
{
    class CommandServiceHandler
    {
        private CommandService _commands;
        private DiscordSocketClient _discord;
        private IServiceProvider _services;

        public CommandServiceHandler(IServiceProvider services)
        {
            _services = services;
            _commands = _services.GetRequiredService<CommandService>();
            _discord = _services.GetRequiredService<DiscordSocketClient>();

            _commands.CommandExecuted += OnCommandExecuted;
            _discord.MessageReceived += OnMessageRecieved;
        }

        public async Task InitializeAsync()
        {
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        private async Task OnMessageRecieved(SocketMessage message)
        {
            if (message.Source != MessageSource.User) return;
            if (!(message is SocketUserMessage msg)) return;
            int argPos = 0;
            if (!msg.HasCharPrefix('!', ref argPos)) return;

            var context = new SocketCommandContext(_discord, msg);

            await _commands.ExecuteAsync(context, argPos, _services);

        }

        private async Task OnCommandExecuted(Optional<CommandInfo> command, ICommandContext context, IResult result)
        {
            if (!command.IsSpecified) return;

            if (result.IsSuccess) return;

            await context.Channel.SendMessageAsync($"error: {result}");
        }
    }
}
