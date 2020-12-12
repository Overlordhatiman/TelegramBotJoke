
namespace TelegramBotJoke.Models
{
    public class Joke
    {
        private string id;
        private string content;
        private bool nsfw;
        private int upvotes;
        private int downvotes;

        public string Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public bool Nsfw { get => nsfw; set => nsfw = value; }
        public int Upvotes { get => upvotes; set => upvotes = value; }
        public int Downvotes { get => downvotes; set => downvotes = value; }
    }
}