using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SayHello.Models
{
    public class Users
    {
        private SayHelloEntities _sayHello = new SayHelloEntities();

        public IQueryable<HelloUsers> GetUsers()
        {
            return from u in _sayHello.HelloUsers
                   select u;
        }

        public HelloUsers GetUsers(int userId)
        {
            return _sayHello.HelloUsers.FirstOrDefault(u => u.UserId == userId);
        }
    }
}