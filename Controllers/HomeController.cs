using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("process")]
        [HttpPost]
        public IActionResult Process(Survey currentSurvey)
        {

            if (!ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return View("Index");
            }
            else
            {
                // System.Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Result", currentSurvey);
            }
           
        }

        // [HttpGet]
        // [Route("result")]
        // // public ViewResult Result(string name, string location, string language, string comment)
        // public ViewResult ResultMethod(string name, string location, string language, string comment)
        // {

        //     ViewBag.userName = name;
        //     ViewBag.userLocation = location;
        //     ViewBag.userLanguage = language;
        //     ViewBag.userComment = comment;

        //     return View("Result");
        // }

    }
}
