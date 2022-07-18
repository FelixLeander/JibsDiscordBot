using System;

using JibsBot.Data;
using JibsBot.Helper;
using JibsBot.Instances;

using Discord;
using Discord.Net;
using Discord.API;
using Discord.Rest;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Interactions;
using Discord.Net.WebSockets;

namespace JibsBot;

public static class Startup
{
    private static int _botCount = 0;
    private static List<FlandersBotHandler> _botConList = new();

    public static void NotifyBotsClose(bool throwOnFirstException)
    {
        _botConList.ForEach((F) => F.CancellationTokenSource.Cancel(throwOnFirstException));

        _botConList.Where((w) =>
        {
            if (!w.Active)
                _botConList.Remove(w);

            return w.Active;
        });
    }
    public static Task Main()
    {
        Console.WriteLine($"For help/feedback/etc. Discord: {AppInfo._contact}{Environment.NewLine}Version: {AppInfo._version}{Environment.NewLine}");
        try
        {
            return CreateAndConfigureClient();
        }
        catch (WebSocketClosedException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            string logFile = Path.Combine(Environment.CurrentDirectory, "CrashReport.txt");
            Console.WriteLine($"There has been an Error. Crash report at:{Environment.NewLine}{logFile}{Environment.NewLine}{ex.Message}");
            File.AppendAllLines(logFile, new string[] { $"[UTC:{DateTime.UtcNow:u}] -- {ex.Message} -- {ex.StackTrace}" });
            return Task.FromResult(0);
        }
    }

    public static async Task CreateAndConfigureClient()
    {
        var botHandler = new FlandersBotHandler(_botCount++, new DiscordSocketClient(new DiscordSocketConfig
        {
            AlwaysDownloadUsers = true,
            MessageCacheSize = 100
        }), new CancellationTokenSource());
        _botConList.Add(botHandler);

        botHandler.Client.Log += botHandler.Client_LogAsync;
        botHandler.Client.Ready += botHandler.Client_ReadyAsync;
        botHandler.Client.MessageReceived += botHandler.Client_MessageReceivedAsync;
        botHandler.Client.UserVoiceStateUpdated += botHandler.Client_UserVoiceStateUpdatedAsync;

        await botHandler.Client.LoginAsync(TokenType.Bot, AppInfo._token);
        await botHandler.Client.StartAsync();

        botHandler.Active = true;
        Console.WriteLine($"{botHandler.Name} is running.");

        try
        {
            await Task.Delay(-1, botHandler.CancellationTokenSource.Token); //Blocks indefinitely
        }
        finally
        {
            await botHandler.Client.StopAsync();
            botHandler.Active = false;
            Console.WriteLine($"{botHandler.Name} has finished.");
            botHandler.Client.Dispose();
        }
    }
}

