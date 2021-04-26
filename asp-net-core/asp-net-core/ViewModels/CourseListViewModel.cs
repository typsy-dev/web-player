using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typsy.Demo.WebPlayer.Models.Courses;

namespace Typsy.Demo.WebPlayer.ViewModels
{
    public class CourseListViewModel : BaseViewModel
    {
        public CourseListViewModel(HttpRequest httpRequest) : base(httpRequest)
        { }

        internal async Task InitializeAsync()
        {
            CourseListRequest courseListRequest = new CourseListRequest()
            {
                AccountId = Convert.ToInt32(TYPSY_ACCOUNT_ID),
                Email = "bob@company.com",
                Language = "en",
                Source = TYPSY_SOURCE,
                Referrer = this.Referrer
            };

            // Refer to the BaseViewModel to see how the encryption keys are initialized

            var client = new RestClient("https://api.typsy.com");
            var request = new RestRequest("/lms/course-list", Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Typsy-Source", TYPSY_SOURCE);
            request.AddHeader("Typsy-Timestamp", this.Timestamp);
            request.AddHeader("Typsy-Account-Id", TYPSY_ACCOUNT_ID);
            request.AddHeader("Typsy-Key", this.EncryptedKey);
            request.AddHeader("Referer", this.Referrer); 

            request.AddJsonBody(courseListRequest);

            var json = await client.ExecuteAsync(request);

            var response = JsonConvert.DeserializeObject<CourseListResponse>(json.Content);

            if (response.Success)
            {
                this.Courses = response.Courses;
            }
        }

        public List<Course> Courses { get; protected set; }
    }
}
