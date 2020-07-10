using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using DynamicMenu.Models.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly IMyTasksRepository myTasksRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public MyTasksController(IMyTasksRepository myTasksRepository
                                 , UserManager<ApplicationUser> userManager)
        {
            this.myTasksRepository = myTasksRepository;
            this.userManager = userManager;
        }

        public IActionResult Get()
        {
            var tasks = myTasksRepository.GetTasks();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult GetByUserId()
        {
            var user = User.Identity.Name;
            var userId = userManager.Users.Where(x => x.UserName == user).Select(x => x.Id).FirstOrDefault().ToString();
            var tasks = myTasksRepository.GetByUser(userId);
            return View(tasks);
        }

        [HttpGet]
        public IActionResult CreateNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNew(MyTasks tasks)
        {
            var user = User.Identity.Name;
            var userId = userManager.Users.Where(x => x.UserName == user).Select(x => x.Id).FirstOrDefault().ToString();
            var result = myTasksRepository.Insert(tasks, userId);
            return RedirectToAction("GetByUserId");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = myTasksRepository.GetById(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(MyTasks tasks)
        {
            var user = User.Identity.Name;
            var userId = userManager.Users.Where(x => x.UserName == user).Select(x => x.Id).FirstOrDefault().ToString();
            var task = myTasksRepository.Update(tasks,userId);
            return RedirectToAction("GetByUserId");
        }

        public IActionResult Delete(int id)
        {
            var result = myTasksRepository.Delete(id);
            return RedirectToAction("GetByUserId");
        }
    }
}