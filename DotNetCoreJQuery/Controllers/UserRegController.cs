using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreJQuery.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreJQuery.Controllers
{
    public class UserRegController : Controller
    {
        //GET
        public IActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Index(UserReg model )
        {
            if (ModelState.IsValid)
            {
                return View(model);
                //return RedirectToAction("Index");
            }
            //ModelState.AddModelError("", "** Error from controller!!!. Please fill all the mandatory fields.");
            return View();
        }
    }
}