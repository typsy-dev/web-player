using Newtonsoft.Json;

namespace Typsy.Demo.WebPlayer.Models.Quizzes
{
    public class Quiz
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
