using Newtonsoft.Json;

namespace Typsy.Demo.WebPlayer.Models
{
    public class ResponseBase
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
