using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;

namespace WebAPI.Controller
{
    public class UserController : ApiController
    {
        pyramidofneedsEntities1 conn = new pyramidofneedsEntities1();
        // GET: api/user
        
        public List<user> Get()
        {
            return conn.users.ToList();

            /*var xmldoc = new XmlDocument();
            List<user> lists = conn.users.ToList();
            xmldoc.LoadXml(lists);
            var fromXml = JsonConvert.SerializeXmlNode(xmldoc);
            var fromJson = JsonConvert.DeserializeObject<Rootobject>(fromXml); */

        }

        // GET: api/user/5
       // api/user/?id=demco@live.com Provera mejla, zuezetost
        public user Get(string id)
        {
            return conn.users.Where(x => x.email == id ).FirstOrDefault();
            //find actual profile, or null
        }
        // api/user/?id=demco@live.com&pass=sifra , provera za login
        public user Get(string id,string pass)
        {
            return conn.users.Where(x => x.email == id && x.password==pass).FirstOrDefault();
            //find actual profile, or null
        }

        // POST: api/user - poziva ga funkcija iz androida da reg
        public void Post([FromBody] user value)
        {
            user novi = new user();
            novi.email = value.email;
            novi.password = value.password;
            
            conn.users.Add(novi);
            conn.SaveChanges();

        }

        // PUT: api/user/5
        public void Put(int id, [FromBody] user value)
        {
        }

        // DELETE: api/user/5
        public void Delete(string id)
        {
            user brisi = conn.users.Where(x => x.email == id).FirstOrDefault();
            conn.users.Remove(brisi);
            conn.SaveChanges();
        }
    }
}
