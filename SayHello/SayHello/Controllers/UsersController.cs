using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SayHello.Models;

namespace SayHello.Controllers
{
    public class UsersController : ApiController
    {
        //  Test
        HelloUsers[] users = new HelloUsers[]
        {
            new HelloUsers{ userId=1, username="xiaoming", password="123", mail="111@123.com", phone="13400000000" },
            new HelloUsers{ userId=2, username="xiaohong", password="111", mail="112@123.com", phone="13400000001" }
        };

        // GET: api/Users
        public IEnumerable<HelloUsers> GetUsers()
        {
            return users;
        }

        // GET: api/Users/5
        public IHttpActionResult GetUsersById(int id)
        {
            var user = (from u in users
                      where u.userId == id
                      select new HelloUsers{
                          userId =u.userId, username=u.username, mail=u.mail, phone=u.phone
                      });
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
