using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typsy.Demo.WebPlayer.Utilities;

namespace Typsy.Demo.WebPlayer.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        private readonly int _lessonId;

        public PlayerViewModel(HttpRequest httpRequest, int lessonId) : base(httpRequest)
        {
            _lessonId = lessonId;
        }

        internal void Initialize()
        {
            // INSERT LOGIC TO LOOKUP THE EMAIL ADDRESS AND NAME OF THE USER ACCESSING THE PAGE.  THIS WILL COME FROM THE CORPORATE IDENTITY SYSTEM.
            // You must pass across a valid email address
            string email = "bob.smith@yourcompany.com";
            string firstname = "Bob";
            string lastname = "Smith";

            // Refer to the BaseViewModel to see how the encryption keys are initialized

            this.Url = $"https://player.typsy.com/lesson/{_lessonId}?aid={TYPSY_ACCOUNT_ID}&t={this.Timestamp}&e={email}&s={TYPSY_SOURCE}&key={this.EncryptedKey}&f={firstname}&l={lastname}&r={this.Referrer}&title=true&desc=true&cc=eng";
        }

        public string Url { get; protected set; }
    }
}
