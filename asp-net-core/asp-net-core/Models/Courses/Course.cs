using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typsy.Demo.WebPlayer.Models.Categories;
using Typsy.Demo.WebPlayer.Models.Instructors;
using Typsy.Demo.WebPlayer.Models.Lessons;
using Typsy.Demo.WebPlayer.Models.Quizzes;

namespace Typsy.Demo.WebPlayer.Models.Courses
{
    public class Course
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lessons")]
        public ICollection<Lesson> Lessons { get; set; }

        [JsonProperty("instructor")]
        public Instructor Instructor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("quiz")]
        public Quiz Quiz { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }
    }
}
