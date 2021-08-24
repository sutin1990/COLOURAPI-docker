using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColourAPI.Controllers.Models;
using ColourAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColourAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private demoContext _demoContext;
        public ValuesController(demoContext demoContext)
        {
            _demoContext = demoContext;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employees>> Get()
        {
            return _demoContext.Employees;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<List<Employees>> Get(int id)
        {
            var result = _demoContext.Employees.Where(w => w.Id != id).ToList();
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
