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
        ////  TEst
        //HelloUsers[] users = new HelloUsers[] {
        //    new HelloUsers { },
        //    new HelloUsers { },
        //};

        private Users _users = new Users();

        // GET: api/Users
        public IQueryable<HelloUsers> GetUsers()
        {
            IQueryable<HelloUsers> users = _users.GetUsers();
            return users;
        }

        // GET: api/Users/5
        public IHttpActionResult GetUsersById(int id)
        {
            var user = _users.GetUsers(id);
            if (user == null)
                return NotFound();
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
