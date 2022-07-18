using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JibsBot.Instances
{
    internal class FlandersBotHandler
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = false;
        public DiscordSocketClient Client { get; set; }
        public CancellationTokenSource CancellationTokenSource { get; set; }

        public FlandersBotHandler(int idNum, DiscordSocketClient client, CancellationTokenSource cancellationTokenSource)
        {
            IdNum = idNum;
            Name = $"Client-{IdNum}";
            Client = client;
            CancellationTokenSource = cancellationTokenSource;
        }

        internal async Task Client_ReadyAsync()
        {
            Console.WriteLine($"{Name} is ready.");
            return;
        }

        internal async Task Client_LogAsync(LogMessage msg)
        {
            string text = $"[UTC:{DateTime.UtcNow:u}] {Name} -- {msg.Severity} -- {msg.Message}";
            Console.WriteLine($"------{text}{Environment.NewLine}");
            File.AppendAllLines("log.txt", new string[] { text });
            return;
        }
        internal async Task Client_MessageReceivedAsync(SocketMessage arg)
        {
            if (arg.Author.Id == Client.CurrentUser.Id)
                return;

            await arg.Channel.SendMessageAsync($"{arg.Author.Mention} you talking shit?");
            return;
        }
        internal async Task Client_UserVoiceStateUpdatedAsync(SocketUser arg1, SocketVoiceState arg2, SocketVoiceState arg3)
        {
            if (arg1.IsBot)
                return;


        }
    }
}

