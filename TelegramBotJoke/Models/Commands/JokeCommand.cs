using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotJoke.Models.Commands
{
    public class JokeCommand : Command
    {
        public override string Name => "GiveJoke";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var MessageId = message.MessageId;

            var Restclient = new RestClient("https://joke3.p.rapidapi.com/v1/joke?nsfw=false");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "6b0338b559msh0f5b4fae99c205cp1b304cjsn93f7f906d12b");
            request.AddHeader("x-rapidapi-host", "joke3.p.rapidapi.com");
            IRestResponse response = Restclient.Execute(request);
            Joke joke = JsonConvert.DeserializeObject<Joke>(response.Content);

            await client.SendTextMessageAsync(chatId, joke.Content, replyToMessageId: MessageId);
        }
    }
}