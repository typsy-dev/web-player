using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typsy.Demo.WebPlayer.ViewModels;

namespace Typsy.Demo.WebPlayer.Controllers
{
    public class CoursesController : Controller
    {
        public async Task<ActionResult> Index()
        {
            CourseListViewModel viewModel = new CourseListViewModel(this.Request);

            await viewModel.InitializeAsync();

            return View(viewModel);
        }
    }
}
