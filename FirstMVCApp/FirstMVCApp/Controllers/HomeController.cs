using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Retrieves main Index page for root route
        /// </summary>
        /// <returns>Returns the Index.cshtml page</returns>
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        /// <summary>
        /// Grabs data from our form and redirects to the Result action
        /// </summary>
        /// <param name="begYear">First year of range selected by user</param>
        /// <param name="endYear">Last year of range selected by user</param>
        /// <returns>An IActionResult redirect to Result aciton</returns>
        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            return RedirectToAction("Result", new { begYear, endYear });
        }

        /// <summary>
        /// Renders the Result page using the data we grabbed from our csv file
        /// </summary>
        /// <param name="begYear">Starting year range, sent by user</param>
        /// <param name="endYear">Ending year range, sent by user</param>
        /// <returns>The result view</returns>
        public ViewResult Result(int begYear, int endYear)
        {
            List<TimePerson> result = TimePerson.GetPersons(begYear, endYear);
            return View(result);
        }
    }
}
