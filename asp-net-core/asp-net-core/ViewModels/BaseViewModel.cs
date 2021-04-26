using Microsoft.AspNetCore.Http;
using System;
using Typsy.Demo.WebPlayer.Utilities;

namespace Typsy.Demo.WebPlayer.ViewModels
{
    public class BaseViewModel
    {
        protected const string TYPSY_ACCOUNT_ID = "INSERT THE NUMERIC ACCOUNT ID YOU WILL BE PROVIDED BY TYPSY";
        protected const string TYPSY_SOURCE = "INSERT THE SOURCE NAME YOU WILL BE PROVIDED BY TYPSY";
        protected const string TYPSY_KEY = "INSERT THE TYPSY KEY YOU WILL BE PROVIDED BY TYPSY";

        public BaseViewModel(HttpRequest httpRequest)
        {
            this.Timestamp = DateTime.UtcNow.ToString("O");
            this.EncryptedKeyTemplate = $"{TYPSY_KEY}:{this.Timestamp}";
            this.EncryptedKey = EncryptionHelper.CreateHmacSha256(this.EncryptedKeyTemplate, TYPSY_KEY);

            this.Referrer = $"{httpRequest.Scheme}://{httpRequest.Host}{httpRequest.Path}{httpRequest.QueryString}";
        }

        public string Timestamp { get; protected set; }
        
        public string EncryptedKey { get; protected set; }
        
        public string Referrer { get; set; }

        private string EncryptedKeyTemplate { get; set; }
    }
}
