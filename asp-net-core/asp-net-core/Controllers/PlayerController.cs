using System;
using Microsoft.AspNetCore.Mvc;
using Typsy.Demo.WebPlayer.Utilities;
using Typsy.Demo.WebPlayer.ViewModels;

namespace Typsy.Demo.WebPlayer.Controllers
{
    public class PlayerController : Controller
    {
        [HttpGet]
        [Route("player/{lessonId}")]
        public IActionResult Index(int lessonId = 903)
        {
            PlayerViewModel viewModel = new PlayerViewModel(this.Request, lessonId);

            viewModel.Initialize();

            return View(viewModel);
        }
    }
}