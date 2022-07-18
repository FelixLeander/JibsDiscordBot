using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.API;
using Discord.Commands;
using Discord.Interactions;
using Discord.Net;
using Discord.Rest;
using JibsBot.Instances;

namespace JibsBot.Helper
{
    internal static class WrapDiscordCmd
    {
        internal static bool SendMessage(this FlandersBotHandler flandersBotHandler)
        {
            return flandersBotHandler.SendMessage();



            return true;
        }
    }
}
