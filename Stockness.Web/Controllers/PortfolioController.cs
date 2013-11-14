using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class PortfolioController : ApiController
    {
        // GET api/portfolio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/portfolio/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/portfolio
        public void Post([FromBody]string value)
        {
        }

        // PUT api/portfolio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/portfolio/5
        public void Delete(int id)
        {
        }
    }
}
