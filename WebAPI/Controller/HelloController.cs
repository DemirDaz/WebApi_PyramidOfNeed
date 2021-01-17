using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controller
{
    public class HelloController : ApiController
        
    {
        pyramidofneedsEntities1 conn = new pyramidofneedsEntities1();
        // GET: api/hello
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/hello/5
        public IEnumerable<user> Get(int id)
        {
            return conn.users.ToList();
        }

        // POST: api/hello
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/hello/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/hello/5
        public void Delete(int id)
        {
        }
    }
}
