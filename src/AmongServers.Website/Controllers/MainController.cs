using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AmongServers.Website.Controllers
{
    /// <summary>
    /// Main controller.
    /// </summary>
    public class MainController : Controller
    {
        /// <summary>
        /// Index page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
