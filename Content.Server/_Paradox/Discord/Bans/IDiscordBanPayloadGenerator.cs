using Content.Server.Discord;

namespace Content.Server._Paradox.Discord.Bans;

public interface IDiscordBanPayloadGenerator
{
    WebhookPayload Generate(BanInfo info);
}