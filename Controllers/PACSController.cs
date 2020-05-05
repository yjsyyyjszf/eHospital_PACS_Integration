using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace eHospital_PACS_Integration.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PACSController : ControllerBase
    {
        public string baseUrl = "https://demo.orthanc-server.com/";

        // GET: api/PACS
        [Route("instance")]
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {

            string url = baseUrl + "instances";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(url))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
                return new string[] {data };
            }

            return new string[] { "value1", "value2" };
        }

        // GET: api/PACS/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PACS
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PACS/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
