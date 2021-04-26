using Newtonsoft.Json;

namespace Typsy.Demo.WebPlayer.Models.Categories
{
    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}
