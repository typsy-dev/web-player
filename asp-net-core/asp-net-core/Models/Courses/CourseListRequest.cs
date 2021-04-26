using Newtonsoft.Json;

namespace Typsy.Demo.WebPlayer.Models.Courses
{
    public class CourseListRequest
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }
    }
}
