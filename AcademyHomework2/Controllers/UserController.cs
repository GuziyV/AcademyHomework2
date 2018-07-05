using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcademyHomework2.Services;

namespace AcademyHomework2.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        //GET: User/Index
        public IActionResult Index()
        {
            var users = userService.GetAll();
            return View(users);
        }

        //GET: User/Task1
        public IActionResult Task1()
        {
            var users = userService.GetAll();
            return View(users);
        }
        //GET: User/Task2
        public IActionResult Task2()
        {
            var users = userService.GetAll();
            return View(users);
        }
        //GET: User/Task3
        public IActionResult Task3()
        {
            var users = userService.GetAll();
            return View(users);
        }
        //GET: User/Task4
        public IActionResult Task4()
        {
            var users = userService.GetAll();
            return View(users);
        }
        //GET: User/Task5
        public IActionResult Task5()
        {
            var users = userService.GetAll();
            return View(users);
        }
        //GET: User/Task6
        public IActionResult Task6()
        {
            var users = userService.GetAll();
            return View(users);
        }
    }
}