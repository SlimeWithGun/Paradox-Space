using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    /// Enables or disables authorization via Discord.
    /// </summary>
    public static readonly CVarDef<bool> DiscordAuthEnable =
        CVarDef.Create("discord.auth_enable", false, CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// This secret key is used to encrypt UserIDs.
    /// </summary>
    public static readonly CVarDef<int> DiscordAuthEncryptionKey =
        CVarDef.Create("discord.auth_encryption_key", 0, CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// IP address of the Discord bot server.
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthBotIp =
        CVarDef.Create("discord.auth_bot_ip", "127.0.0.1", CVar.SERVERONLY);

    /// <summary>
    /// Port of the Discord bot server.
    /// </summary>
    public static readonly CVarDef<int> DiscordAuthBotPort =
        CVarDef.Create("discord.auth_bot_port", 6767, CVar.SERVERONLY);
}
