using Newtonsoft.Json;
using System.Collections.Generic;

namespace Typsy.Demo.WebPlayer.Models.Courses
{
    public class CourseListResponse : ResponseBase
    {
        [JsonProperty("courses")]
        public List<Course> Courses { get; set; }
    }
}
