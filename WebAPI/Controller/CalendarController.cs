using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controller
{
    public class CalendarController : ApiController
    {
        pyramidofneedsEntities1 conn = new pyramidofneedsEntities1();
        // GET: api/calendar
        public IEnumerable<calendar> Get()
        {
            return conn.calendars.ToList();
        }

        // GET: api/calendar/5
        public calendar Get(int id)
        {
            return conn.calendars.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/calendar
        public void Post([FromBody] calendar value)
        {
            calendar novi = new calendar();
            novi.user = value.user;
            novi.date = value.date;
            novi.C1 = value.C1;
            novi.C2 = value.C2;
            novi.C3 = value.C3;
            novi.C4 = value.C4;
            novi.C5 = value.C5;
            
            conn.calendars.Add(novi);
            conn.SaveChanges();
        }

        // PUT: api/calendar/5
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/calendar/5
        public void Delete(string user,DateTime date)
        {
            calendar brisi = conn.calendars.Where(x => x.user == user && x.date ==date).FirstOrDefault();
            conn.calendars.Remove(brisi);
            conn.SaveChanges();
        }
    }
}
