using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JibsBot.Helper;

namespace JibsBot.Data;

internal static class AppInfo
{
    public static readonly Version _version = Environment.Version;
    public static readonly string _contact = "Lander#2332";
    internal static readonly string _token = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "token.txt"));
}
