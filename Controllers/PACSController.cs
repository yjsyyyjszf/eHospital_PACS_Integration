using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace eHospital_PACS_Integration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PACSController : ControllerBase
    {

        // GET: api/PACS
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var data = Orthanc.Orthanc.InstanceAsync();
            
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
