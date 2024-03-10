using System;
using Microsoft.Extensions.Configuration;

namespace _0_Framwork.Application.Sms
{
    public class SmsService : ISmsService
    {
        private readonly IConfiguration _configuration;

        public SmsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Send(string number, string message)
        {
            string Token = GetToken();
            DateTime SendDateTime = DateTime.Now;
            string SMSMessageText = message;
            string LineNumber = "public";
            string[] Mobiles = new string[]
            {
                number
            };

            using var client = new System.Net.WebClient();

            client.Headers.Add(System.Net.HttpRequestHeader.Authorization, Token);
            var data = new System.Collections.Specialized.NameValueCollection()
            {
                { "SendDateTime", SendDateTime.ToString() },
                { "SMSMessageText", SMSMessageText  },
                { "LineNumber", LineNumber },
                { "Mobiles", string.Join(",",Mobiles)  },
            };

            byte[] bytes = client.UploadValues("https://portal.amootsms.com/rest/SendSimple", data);

            var json = System.Text.Encoding.UTF8.GetString(bytes);//خروجی
        }

        private string GetToken()
        {
            var smsInfo = _configuration.GetSection("SmsProfile");
            return smsInfo["Token"];
        }
    }
}
