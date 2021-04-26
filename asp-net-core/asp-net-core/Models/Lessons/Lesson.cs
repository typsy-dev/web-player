using Newtonsoft.Json;
using Typsy.Demo.WebPlayer.Models.Categories;
using Typsy.Demo.WebPlayer.Models.Instructors;

namespace Typsy.Demo.WebPlayer.Models.Lessons
{
    public class Lesson
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("instructor")]
        public Instructor Instructor { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("gracePeriod")]
        public int GracePeriod { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("isCustomContent")]
        public bool IsCustomContent { get; set; }
    }
}
