using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreJQuery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreJQuery.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public ActionResult Index()
        {
            CitiesInfo model = new CitiesInfo();

            model.CountryInfosList.Add(new CountryInfo { CId=0, CName="-- Select Country --"});
            model.CountryInfosList.Add (new CountryInfo { CId=101, CName="India"});
            model.CountryInfosList.Add(new CountryInfo { CId=102, CName="USA"});
            model.CountryInfosList.Add(new CountryInfo { CId = 103, CName = "UK" });

            return View(model);
        }

        [HttpPost]
        public IActionResult StateData(int cid)
        {
            List < StateInfo > states = new List<StateInfo>()
            {
                new StateInfo{SId=1, CId=101, SName="Uttar Pradesh"},
                 new StateInfo{SId=2, CId=101, SName="Uttarakhand"},
                  new StateInfo{SId=3, CId=101, SName="Bihar"},

                   new StateInfo{SId=4, CId=102, SName="USA State1"},
                 new StateInfo{SId=5, CId=102, SName="USA State2"},

                  new StateInfo{SId=6, CId=103, SName="UK State1"},
                  new StateInfo{SId=7, CId=103, SName="UK State2"}
            };

            CitiesInfo model = new CitiesInfo();
            model.StateInfosList = states.Where(s => s.CId == cid).ToList();

            return Json(model);
        }
    }
}