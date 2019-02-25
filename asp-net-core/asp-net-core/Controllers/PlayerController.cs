﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Typsy.Demo.WebPlayer.Models;
using Typsy.Demo.WebPlayer.Utilities;

namespace Typsy.Demo.WebPlayer.Controllers
{
    public class PlayerController : Controller
    {
        private const string TYPSY_ACCOUNT_ID = "INSERT THE ACCOUNT ID";
        private const string TYPSY_SOURCE = "INSERT THE SOURCE NAME";
        private const string TYPSY_KEY = "INSERT THE SOURCE NAME";

        [HttpGet]
        [Route("player/{lessonId}")]
        public IActionResult Index(int lessonId = 903)
        {
            string timestamp = DateTime.UtcNow.ToString("O");
            string encryptedKeyTemplate = $"{TYPSY_KEY}:{timestamp}";
            string encryptedKey = EncryptionHelper.CreateHmacSha256(encryptedKeyTemplate, TYPSY_KEY);

            // INSERT LOGIC TO LOOKUP THE EMAIL ADDRESS AND NAME OF THE USER ACCESSING THE PAGE
            string email = "bob.smith@yourcompany.com";
            string firstname = "Bob";
            string lastname = "Smith";

            var referrer = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.Path}{this.Request.QueryString}";

            string url = $"https://player.typsy.com/lesson/{lessonId}?aid={TYPSY_ACCOUNT_ID}&t={timestamp}&e={email}&s={TYPSY_SOURCE}&key={encryptedKey}&f={firstname}&l={lastname}&r={referrer}";

            PlayerViewModel viewModel = new PlayerViewModel();
            viewModel.Url = url;

            return View(viewModel);
        }
    }
}