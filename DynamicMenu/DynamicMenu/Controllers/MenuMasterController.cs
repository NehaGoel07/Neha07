using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    public class MenuMasterController : Controller
    {
        private readonly IMenuMasterService _masterService;

        public MenuMasterController(IMenuMasterService masterService)
        {
            _masterService = masterService;
           
        }

        /// <summary>
        /// Get the list of menu
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult GetMenu()
        {
            var result = _masterService.GetMenuMaster();
                return View(result);
            
        }

        [HttpGet]
        public IActionResult GetMenuByRole(string role)
        {
            var result = _masterService.GetMenuMasterRole(role);
            return View("../MenuMaster/GetMenu",result);
        }

        [HttpGet]
        public IActionResult AddNew()
        {
            var data = _masterService.GetMenuMaster().Select(m => m.MenuID).Distinct().ToList();
            ViewBag.menuData = data;
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(MenuMaster menu)
        {
            _ = _masterService.Add(menu);
            return RedirectToAction("GetMenu");
        }

        /// <summary>
        /// Displays view to edit existing menu
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var menuData = _masterService.GetMenuMaster(id);
            return View(menuData);
        }

        /// <summary>
        /// Edit existing menu
        /// </summary>
        /// <param name="menuMaster"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Edit(MenuMaster menuMaster)
        {
            _masterService.UpdateMenu(menuMaster);
            return RedirectToAction("GetMenu");
        }

        /// <summary>
        /// Delete menu item
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
             _masterService.DeleteMenu(id);
            return RedirectToAction("GetMenu");
        }
    }
}