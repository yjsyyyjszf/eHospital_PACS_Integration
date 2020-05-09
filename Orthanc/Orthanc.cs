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
        private const string e_nf = "Not Found!";
        public static string baseUrl = "https://demo.orthanc-server.com/";
        public static async Task<string> InstanceGetAsync(string id)
        {
            string url = baseUrl + "instances";
            if (id != "")
                url = url + '/' + id;
            using (HttpClient client = new HttpClient())

            using (HttpResponseMessage res = await client.GetAsync(url))
            using (HttpContent content = res.Content)
            {
                var data = await content.ReadAsStringAsync();
                if(data != null)
                    return data;
            }
            return e_nf;
        }

        public static async Task<string> InstancePostAsync()
        {

            string url = baseUrl + "instances";
            using (HttpClient client = new HttpClient())

            using (HttpResponseMessage res = await client.GetAsync(url))
            using (HttpContent content = res.Content)
            {
                var data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }

                return data;
            }

        }


    }
}
