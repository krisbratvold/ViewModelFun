using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            string message = "This is a message I passed in using ViewModel!";
        return View ("index",message);
        }

        [HttpGet("/numbers")]
        public ViewResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
        return View ("numbers",numbers);
        }
        
        [HttpGet("/user")]
        public IActionResult Person()
        {
            Users oneUser = new Users()
            {
                FirstName = "Kris",
                LastName = "Bratvold"
            };
            Users secondUser = new Users()
            {
                FirstName = "Tristan",
                LastName = "Bratvold"
            };
        return View ("user",oneUser);
        }
        [HttpGet("/users")]
        public IActionResult Persons()
        {
            Users oneUser = new Users()
            {
                FirstName = "Kris",
                LastName = "Bratvold"
            };
            Users secondUser = new Users()
            {
                FirstName = "Tristan",
                LastName = "Bratvold"
            };
            List<Users> people = new List<Users>()
            {
                oneUser, secondUser
            };
        return View ("users",people);
        }
    }
}