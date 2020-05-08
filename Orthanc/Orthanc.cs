using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eHospital_PACS_Integration.Model;
using Newtonsoft.Json;

namespace eHospital_PACS_Integration.Orthanc
{
    public class Orthanc
    {
        public static string baseUrl = "https://demo.orthanc-server.com/";
        public static async Task<object> InstanceAsync()
        {

            string url = baseUrl + "instances";
            //The 'using' will help to prevent memory leaks.
            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())

            //Setting up the response...         

            using (HttpResponseMessage res = await client.GetAsync(url))
           
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
                
                var jData = JsonConvert.DeserializeObject(new string[] { data }[0]);

                return jData;
            }

        }
    }
}
