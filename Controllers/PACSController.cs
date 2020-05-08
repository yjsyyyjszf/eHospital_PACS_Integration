using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eHospital_PACS_Integration.Orthanc;
using Newtonsoft.Json.Linq;
using eHospital_PACS_Integration.Model;
using Newtonsoft.Json;
using Flurl.Http;
using System.Text.RegularExpressions;

namespace eHospital_PACS_Integration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PACSController : ControllerBase
    {

        // GET: api/PACS
        [HttpGet]
        public async Task<object> Get()
        {
            var result = await Orthanc.Orthanc.InstanceAsync();
            
            
            return result;
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
            int i = 1;
            i++;
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
