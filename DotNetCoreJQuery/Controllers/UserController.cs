using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreJQuery.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreJQuery.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserInfo userInfo = new UserInfo();
            return View(userInfo);
        }

        [HttpPost]
        public IActionResult AddUser(UserInfo userInfo)
        {
            string UserName = userInfo.Name;
            TempData["message"] = "User " + UserName + " addedd";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateUser(UserInfo userInfo)
        {
            string UserName = userInfo.Name;
            TempData["message"] = "User " + UserName + " updated";
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(UserInfo userInfo)
        {
            string UserName = userInfo.Name;
            TempData["message"] = "User " + UserName + " deleted";
            return RedirectToAction("Index");
        }
    }
}