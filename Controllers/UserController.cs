using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("user")]
        public IActionResult User()
        {
            User newUser = new User(){
                FirstName = "Celi",
                LastName = "Tagi"
            };
            return View(newUser);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {

            User newUser = new User(){
                FirstName = "Jamesie",
                LastName = "Luie"
            };
            // users.Add(newUser); // add to the list if the list was decleared at the top
            User newUser2 = new User(){
                FirstName = "Huepe",
                LastName = "Poee"
            };
            // users.Add(newUser2);

            List<User> users = new List<User>(){
                newUser, newUser2
            };

            return View(users);
        }
    }
}