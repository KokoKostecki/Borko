using BorkoUserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BorkoUserService.Controllers
{
    public class UsersController : ApiController
    {

        private static List<User> Users = new List<Models.User> { new Models.User {Id = 1, Name = "Rex", AmDoggo = true },
        new Models.User {Id = 2, Name = "Fred", AmDoggo = false }, new Models.User { Id = 3, Name = "Bamboozled", AmDoggo = true } };


        public void PostUser(User user)
        {
            Users.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }
    }
}
