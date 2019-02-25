using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Typsy.Demo.WebPlayer.Utilities
{
    public class EncryptionHelper
    {
        /// <summary>
        /// Generates an Hmac Sha256 hash of message with a key.  The following website can be used to test for the same result - http://beautifytools.com/hmac-generator.php
        /// </summary>
        /// <param name="message"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string CreateHmacSha256(string message, string key)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(key);

            HMACMD5 hmacmd5 = new HMACMD5(keyByte);
            HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);
            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);

            byte[] messageBytes = encoding.GetBytes(message);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);

            return ByteToString(hashmessage);
        }

        private static string ByteToString(byte[] buff)
        {
            string sbinary = "";

            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }

            return (sbinary);
        }
    }
}