using Newtonsoft.Json;

namespace Typsy.Demo.WebPlayer.Models.Instructors
{
    public class Instructor
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
