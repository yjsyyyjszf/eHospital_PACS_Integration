using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace eHospital_PACS_Integration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


            string url = "https://YOUR_COMPANY_HERE.beebole-apps.com/api";
            string data = "{\"service\":\"absence.list\", \"company_id\":3}";

            WebRequest myReq = WebRequest.Create(url);
            myReq.Method = "POST";
            myReq.ContentLength = data.Length;
            myReq.ContentType = "application/json; charset=UTF-8";

            string usernamePassword = "YOUR API TOKEN HERE" + ":" + "x";

            UTF8Encoding enc = new UTF8Encoding();

            myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(enc.GetBytes(usernamePassword)));


            using (Stream ds = myReq.GetRequestStream())
            {
                ds.Write(enc.GetBytes(data), 0, data.Length);
            }




        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
