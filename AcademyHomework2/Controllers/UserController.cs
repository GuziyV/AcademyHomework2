﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcademyHomework2.Services;
using AcademyHomework2.Models;

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
            ViewBag.GetUserByCommentIdDict = userService.GetUserByCommentIdDict();
            return View(users);
        }

        //GET: User/getuser/{id}
        public IActionResult GetUser(int id)
        {
            var user = userService.GetUserById(id);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //GET: User/Task1
        public IActionResult Task1()
        {
            return View();
        }
        //POST: User/Task1
        [HttpPost]
        public IActionResult Task1(int id)
        {
            var query = userService.GetNumberOfCommentsById(id);
            if(query == null)
            {
                ViewBag.Error = "User wasn't found";
                return View();
            }
            return View("Task1Result", query);
        }
        //GET: User/Task2
        public IActionResult Task2()
        {
            return View();
        }
        //POST: User/Task2
        [HttpPost]
        public IActionResult Task2(int id)
        {
            var query = userService.GetCommentsWithSmallBodyById(id);
            if (query == null)
            {
                ViewBag.Error = "User wasn't found";
                return View();
            }
            else
            {
                ViewBag.GetUserByCommentIdDict = userService.GetUserByCommentIdDict();
                return View("Task2Result", query);
            }
        }
        //GET: User/Task3
        public IActionResult Task3()
        {
            return View();
        }
        //POST: User/Task3
        [HttpPost]
        public IActionResult Task3(int id)
        {
            var tasks = userService.GetCompletedTasksById(id);
            if(tasks == null)
            {
                ViewBag.Error = "User wasn't found";
                return View();
            }
            return View("Task3Result", tasks);
        }
        //GET: User/Task4
        public IActionResult Task4()
        {
            var users = userService.GetSortedUsers();
            return View(users);
        }
        //GET: User/Task5
        public IActionResult Task5()
        {
            return View();
        }
        //POST: User/Task5
        [HttpPost]
        public IActionResult Task5(int id)
        {
            var structure = userService.GetFirstStructure(id);
            if(structure == null) //if user wasn't found
            {
                ViewBag.Error = "User wasn't found";
                return View();
            }
            return View("Task5Result", structure);
        }
        //GET: User/Task6
        public IActionResult Task6()
        {
            return View();
        }
        //POST: User/Task6
        [HttpPost]
        public IActionResult Task6(int id)
        {
            var structure = userService.GetSecondStructure(id);
            if(structure == null) //If user wasn't found
            {
                ViewBag.Error = "Post wasn't found";
                return View();
            }
            return View("Task6Result", structure);
        }
    }
}
