using DSharpPlus;
using System;
namespace NewVersionBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var discrod = new DiscordClient(new DiscordConfiguration()
            {
                Token = "MTEyOTA2NzEyNTI2MTIxMzc0Nw.GJJ-6m.zqTjb_ItZm1U8qmAh4tyPIjeRv9cRgN9p79wdI",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents
            });

            discrod.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("/test"))
                {
                    await e.Message.RespondAsync("Pong");
                }
            };

            await discrod.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}